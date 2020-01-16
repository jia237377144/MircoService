using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace JLP.Web.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseContentRoot(Directory.GetCurrentDirectory())
            .ConfigureAppConfiguration((hostContext, config) =>
            {
                string envName = hostContext.HostingEnvironment.EnvironmentName;
                config.AddJsonFile("connectionStrings.json", true, true).AddJsonFile($"connectionStrings.{envName}.json", true, true);
                config.AddJsonFile("hosts.json", true, true).AddJsonFile($"hosts.{envName}.json", true, true);

            })
            .ConfigureLogging((hostingContext, config) =>
            {
                config.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                config.AddConsole();//控制台输出日志
                config.AddDebug(); //调试输出日志
                config.AddEventSourceLogger();
            })
            .UseNLog()
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
}
