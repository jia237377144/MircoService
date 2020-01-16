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

namespace Consul_CustomConfigurationSource
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostingContext, builder) =>
            {
                builder.SetBasePath(Directory.GetCurrentDirectory());
                var configuration = builder.Build();
                string environmentName = hostingContext.HostingEnvironment.EnvironmentName;
                builder.AddJsonFile("hosts.json", true, true)
                .AddJsonFile($"hosts.{environmentName}.json", true, true);

                builder.AddConsul(configuration.GetValue<string>("CONSUL_URL").Split(";"), configuration.GetValue<string>("CONSUL_PATH"));
            })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
