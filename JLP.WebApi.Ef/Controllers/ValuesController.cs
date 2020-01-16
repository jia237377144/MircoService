using JLP.WebApi.Ef.Core;
using JLP.WebApi.Ef.Models;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace JLP.WebApi.Ef.Controllers
{
    public class ValuesController : ApiController
    {

        //Notice:
        //HttpResponseMessage Get()和HttpResponseMessage Get([ModelBinder(typeof(CookieModuleBinder))]string accept, [ModelBinder(typeof(CookieModuleBinder))]string acceptEncoding) 不能重载

        /* [HttpGet]
         public HttpResponseMessage Get()
         {
             return ResponseHelper.GetSuccess("Get");
         }*/

        [HttpGet]
        public HttpResponseMessage Get([ModelBinder(typeof(CookieModuleBinder))]string accept, [ModelBinder(typeof(CookieModuleBinder))]string acceptEncoding)
        {
            return ResponseHelper.GetSuccess(new { accept, acceptEncoding });
        }

        [HttpPost]
        //[FromBody]SPU spu  OK
        //SPU spu OK
        //base.Request.Content.ReadAsStringAsync().Result OK
        //[FromUri]SPU spu Error
        public HttpResponseMessage Post(SPU spu)
        {
            return ResponseHelper.GetSuccess(spu);
        }
    }
}
