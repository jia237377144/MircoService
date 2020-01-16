using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Consul_Common.CustomConfigurationSource;

namespace Ocelot.Client2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureHostConfiguration(builder =>
            {
                builder.SetBasePath(Directory.GetCurrentDirectory());
            })
            .ConfigureAppConfiguration((hostingContext, builder) =>
            {
                IHostEnvironment hostEnvironment = hostingContext.HostingEnvironment;
                string environmentName = hostEnvironment.EnvironmentName;
                builder.AddJsonFile("appsettings.json", false, true).AddJsonFile(string.Format("appsettings.{0}.json", environmentName), true, true);
                builder.AddJsonFile("hosts.json", false, true).AddJsonFile(string.Format("hosts.{0}.json", environmentName), true, true);

                //∂¡»°Consul÷–µƒ≈‰÷√
                var configuration = builder.Build();
                builder.AddConsul(configuration.GetValue<string>("ConsulServer:CONSUL_URL").Split(";"), configuration.GetValue<string>("ConsulServer:CONSUL_PATH"));
            })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseUrls();
                    webBuilder.UseStartup<Startup>();
                });
    }
}
