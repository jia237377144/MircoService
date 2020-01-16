using Consul;
using Consul_Common.ConsuleConfig;
using Consul_Common.ConsulRegister;
using Consul_Common.Helper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Consul_Service01
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            this.Env = env;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Env;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //注入Consul Agent实例，可以读取其中的KV
            string consulServerUrl = this.Configuration.GetValue<string>("ConsulServer:CONSUL_URL");
            services.AddSingleton<IConsulClient>(new ConsulClient(clientConfig => clientConfig.Address = new Uri(consulServerUrl)));
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime applicationLifetime,ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

#if !DEBUG

            //注入服务
            app.RegisterConsul(applicationLifetime, this.Configuration, logger);
#endif
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
