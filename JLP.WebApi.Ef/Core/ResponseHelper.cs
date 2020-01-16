using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace JLP.WebApi.Ef.Core
{
    public class ResponseHelper
    {
        public static HttpResponseMessage GetSuccess()
        {
            return new HttpResponseMessage { StatusCode = HttpStatusCode.OK };
        }
        public static HttpResponseMessage GetSuccess(object data)
        {
            return new HttpResponseMessage { StatusCode = HttpStatusCode.OK, Content = new StringContent(JsonConvert.SerializeObject(data)) };
        }

    }
}