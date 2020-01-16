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
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Logging.Debug;
using Microsoft.Extensions.DependencyInjection;

namespace Consul_Service01
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

                var loggerFactory = LoggerFactory.Create(builder =>
                {
                    builder
                        .AddFilter("Microsoft", LogLevel.Warning)
                        .AddFilter("System", LogLevel.Warning)
                        .AddConsole()
                        .AddDebug();
                });
                ILogger logger = loggerFactory.CreateLogger("Program");
                var configuration = builder.Build();
                logger.LogInformation($"Method:{nameof(Program)}, IP:{configuration.GetValue<string>("ConsulServer:CONSUL_URL")},Path:{configuration.GetValue<string>("ConsulServer:CONSUL_PATH")}");
                builder.AddConsul(configuration.GetValue<string>("ConsulServer:CONSUL_URL").Split(";"), configuration.GetValue<string>("ConsulServer:CONSUL_PATH"));
            })
            .ConfigureLogging(log =>
            {
                log.ClearProviders();
                log.AddDebug();
                log.AddConsole();

            })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
