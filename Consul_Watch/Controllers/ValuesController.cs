using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consul;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Consul_Common;
using System.Net.Http;

namespace Consul_Watch.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private IConsulClient _consulClient { get; }

        public ValuesController( IConsulClient consulClient)
        {
            this._consulClient = consulClient;
        }

        [HttpGet]
        public string Get(string key)
        {
            return this._consulClient.KvGet(key);
        }
    }
}
