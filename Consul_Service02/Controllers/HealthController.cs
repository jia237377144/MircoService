using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Consul_Service02.Controllers
{
    [ApiController]
    [Route("api/Health")]
    public class HealthController : ControllerBase
    {

        public IActionResult Get() => Ok("ok");
    }
}