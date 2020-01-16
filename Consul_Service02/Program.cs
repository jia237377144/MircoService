using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Consul_Service02
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
                 IHostEnvironment hostEnvironment = hostingContext.HostingEnvironment;
                 string environmentName = hostEnvironment.EnvironmentName;
                 builder.AddJsonFile("hosts.json", false, true).AddJsonFile(string.Format("hosts.{0}.json", (object)environmentName), true, true);
             })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
