using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading.Tasks;
using Consul;
using Consul_Common.ConsuleConfig;
using Consul_Common.ConsulRegister;
using Consul_Common.Helper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.WebEncoders;
using Newtonsoft.Json;

namespace Consul_Watch
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region 中文乱码问题
            //中文乱码问题 http://www.cnblogs.com/dudu/p/5879913.html
            services.Configure<WebEncoderOptions>(options => options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All));
            services.AddSingleton(HtmlEncoder.Create(UnicodeRanges.All));//避免页面Html非ASCII字符被编码
            #endregion

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

            //app.UseHttpsRedirection();

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
