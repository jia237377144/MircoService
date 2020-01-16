using Consul;
using Consul_Common.ConsuleConfig;
using Consul_Common.Helper;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consul_Common.ConsulRegister
{
    /// <summary>
    /// IApplicationBuilder扩展， 注册服务
    /// </summary>
    public static class AppBuilderExtensions
    {
        /// <summary>
        /// 服务注入到Consul
        /// 每个Agent Client 注册的服务不能重复
        /// </summary>
        /// <param name="app"></param>
        /// <param name="lifetime"></param>
        /// <param name="serviceEntity"></param>
        /// <returns></returns>
        public static IApplicationBuilder RegisterConsul<T>(this IApplicationBuilder app, IHostApplicationLifetime lifetime, IConfiguration configuration, ILogger<T> logger)
        {
            //获取Consul客户端列表
            var ConsulClientConfig = GetConsullientConfig(configuration);

            ServiceEntity serviceEntity = new ServiceEntity
            {
                IP = NetworkHelper.LocalIPAddress(),
                Port = Convert.ToInt32(configuration["Service:Port"]),
                ServiceName = configuration["Service:Name"],
                ConsulClients = ConsulClientConfig
            };

            foreach (var consulConfig in serviceEntity.ConsulClients)
            {
                logger.LogInformation($"注入服务， IP:{consulConfig.IP},Port:{consulConfig.Port}");
                var consulClient = new ConsulClient(x => x.Address = new Uri($"http://{consulConfig.IP}:{consulConfig.Port}"));//请求注册的 Consul 地址

                var agentServices = consulClient.Agent.Services().ConfigureAwait(false).GetAwaiter().GetResult();

                foreach (var agentService in agentServices.Response.Values)
                {
                    //根据IP判断是否已经存在当前服务，如果存在就移除，重新注册
                    if (agentService.Address == consulConfig.IP)
                    {
                        consulClient.Agent.ServiceDeregister(agentService.ID);
                        break;
                    }
                }

                var httpCheck = new AgentServiceCheck()
                {
                    DeregisterCriticalServiceAfter = TimeSpan.FromSeconds(5),//服务启动多久后注册
                    Interval = TimeSpan.FromSeconds(serviceEntity.Interval),//健康检查时间间隔，或者称为心跳间隔
                    HTTP = $"http://{serviceEntity.IP}:{serviceEntity.Port}/api/health",//健康检查地址
                    Timeout = TimeSpan.FromSeconds(serviceEntity.Timeout)
                };


                // Register service with consul
                var registration = new AgentServiceRegistration()
                {
                    Checks = new[] { httpCheck },
                    ID = Guid.NewGuid().ToString(),
                    Name = $"{serviceEntity.ServiceName}",
                    Address = serviceEntity.IP,
                    Port = serviceEntity.Port,
                    Tags = new[] { $"urlprefix-/{serviceEntity.ServiceName}-{serviceEntity.IP}" },//添加 urlprefix-/servicename 格式的 tag 标签，以便 Fabio 识别
                };

                consulClient.Agent.ServiceRegister(registration).Wait();//服务启动时注册，内部实现其实就是使用 Consul API 进行注册（HttpClient发起）
                lifetime.ApplicationStopping.Register(() =>
                {
                    consulClient.Agent.ServiceDeregister(registration.ID).Wait();//服务停止时取消注册
                });
            }

            return app;


        }

        /// <summary>
        /// 从Consul中读取KV配置的Consul客户端数据
        /// </summary>
        /// <returns></returns>
        private static List<ConsulClientConfig> GetConsullientConfig(IConfiguration configuration)
        {
            string configValue = configuration.GetSection("ConsulClints").Value;
            return JsonConvert.DeserializeObject<List<ConsulClientConfig>>(configValue);
        }
    }
}
