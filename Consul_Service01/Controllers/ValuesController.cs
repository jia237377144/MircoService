using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consul;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Consul_Common;
using System.Net.Http;

namespace Consul_Service01.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private IConsulClient _consulClient { get; }
        private ILogger<ValuesController> _logger { get; }

        public ValuesController( IConsulClient consulClient, ILogger<ValuesController> logger)
        {
            this._consulClient = consulClient;
            this._logger = logger;
        }

        [HttpGet]
        public string Get(string key)
        {
            return this._consulClient.KvGet(key);
        }
    }
}
