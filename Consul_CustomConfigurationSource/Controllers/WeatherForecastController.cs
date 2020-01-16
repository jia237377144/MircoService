using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consul;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Consul_CustomConfigurationSource.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private IConfiguration _configuration { get; }
        private IConsulClient _consulClient { get; }

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            IConfiguration configuration
            //, IConsulClient consulClient
            )
        {
            _logger = logger;
            this._configuration = configuration;
            //this._consulClient = consulClient;
        }

        [HttpGet]
        public string Get(string key)
        {
            //var rerponse = this._consulClient.KV.Get(key).Result.Response;
            return this._configuration.GetValue<string>(key);
        }
    }
}
