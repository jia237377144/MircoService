using JLP.WebApi.Ef.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.ValueProviders;

namespace JLP.WebApi.Ef
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务
            config.MessageHandlers.Insert(0, CompressHandler.GetSingleton());
            config.Services.Add(typeof(ValueProviderFactory), new CookieValueProviderFactory());

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { controller = "Values", id = RouteParameter.Optional }
            );
        }
    }
}
