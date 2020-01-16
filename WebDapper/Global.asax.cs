using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using JLP.IService;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebDapper.Controllers;

namespace WebDapper
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString;
            /*依赖注入*/
            /*
            var builder = new ContainerBuilder();
            // 注册webapi的所有控制器
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            // 注册一个用于测试的组件。
            string connectionString = ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString;
            var iService = Assembly.Load("JLP.IService");
            var service = Assembly.Load("JLP.Service");
            builder.RegisterAssemblyTypes(iService, service)
                .Where(t => t.Name.EndsWith("Service"));
            builder.RegisterInstance<IDbConnection>(new MySqlConnection(connectionString));
            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
            */

            #region 自动注入
            var builder = new ContainerBuilder();

            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            // Register your Web MVC controllers.
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);

            // OPTIONAL: Register the Autofac model binder provider.
            builder.RegisterWebApiModelBinderProvider();

            var iService = Assembly.Load("JLP.IService");
            var service = Assembly.Load("JLP.Service");
            builder.RegisterAssemblyTypes(iService, service)
                .Where(t => t.Name.EndsWith("Service")).AsImplementedInterfaces();
            //builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            builder.RegisterInstance(new MySqlConnection(connectionString)).As<IDbConnection>();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            #endregion


            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
