using JLP.IService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Results;

namespace WebDapper.Controllers
{
    public class AdInfoController : ApiController
    {
        private IAdInfoService AdInfoService { get; }
        public AdInfoController(IAdInfoService adInfoService)
        {
            this.AdInfoService = adInfoService;
        }

        public HttpResponseMessage GetAdInfo(int id)
        {
            var item = this.AdInfoService.Get(id);
            //var item = new { Name = "Tom" };
            string json = JsonConvert.SerializeObject(item);
            return new HttpResponseMessage() {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
        }

    }
}
