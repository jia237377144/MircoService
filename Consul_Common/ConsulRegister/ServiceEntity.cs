using Consul_Common.ConsuleConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consul_Common.ConsulRegister
{
    /// <summary>
    /// 注册服务实体
    /// </summary>
    public class ServiceEntity
    {
        /// <summary>
        /// 服务的IP
        /// </summary>
        public string IP { get; set; }
        /// <summary>
        /// 服务的端口
        /// </summary>
        public int Port { get; set; }
        /// <summary>
        /// 服务名称
        /// </summary>
        public string ServiceName { get; set; }
        /// <summary>
        /// Consul Client的IP
        /// </summary>
        public string ConsulIP { get; set; }

        /// <summary>
        /// 注册的客户端列表
        /// </summary>
        public List<ConsulClientConfig> ConsulClients { get; set; }

        /// <summary>
        /// 健康检查间隔
        /// </summary>
        public int Interval { get; set; } = 10;

        /// <summary>
        /// 健康价差超时间
        /// </summary>
        public int Timeout { get; set; } = 5;
    }
}
