using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JLP.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        [Route("value1")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value1" };
        }

        [HttpGet]
        [Route("value2")]
        [Authorize]
        public ActionResult<IEnumerable<string>> Get2()
        {
            //这是获取自定义参数的方法
            var authEnumerable = HttpContext.AuthenticateAsync().Result.Principal.Claims;

            string name = authEnumerable.FirstOrDefault(a => a.Type == ClaimTypes.NameIdentifier).Value;


            return new string[] { "value2", "value2", name };
        }

        [HttpGet]
        [Route("value3")]
        //[Authorize("Permission")]
        public ActionResult<IEnumerable<string>> Get3()
        {
            //这是获取自定义参数的方法
            var auth = HttpContext.AuthenticateAsync().Result.Principal.Claims;
            var userName = auth.FirstOrDefault(t => t.Type.Equals(ClaimTypes.NameIdentifier))?.Value;
            var role = auth.FirstOrDefault(t => t.Type.Equals(ClaimTypes.Role))?.Value;
            return new string[] { "这个接口有管理员权限才可以访问", $"userName={userName}", $"Role={role}" };
        }
    }
}