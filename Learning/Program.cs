using Autofac;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Learning
{
    class Program
    {

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            //单例模式，所有的实例都是同一个
            //builder.RegisterType<MyResource>().As<IMyResource>().SingleInstance();
            //默认方式，每次都会创建新实例，和transient一样
            //builder.RegisterType<MyResource>().As<IMyResource>().InstancePerDependency();
            //用于嵌套生命周期作用域，每个生命周期作用域的每个嵌套的生命周期作用域内最多有一个单一实例
            //builder.RegisterType<MyResource>().As<IMyResource>().InstancePerLifetimeScope();
            //每个匹配生命周期作用域的组件在每个名称匹配的嵌套生命周期作用域中最多只会有一个单一实例
            //只要是使用tag创建的作用域或者是tag作用域的子作用域那么这个实例就是单一的实例
            builder.RegisterType<MyResource>().As<IMyResource>().InstancePerMatchingLifetimeScope("myrequest");
            //每个请求一个实例
            builder.RegisterType<MyResource>().As<IMyResource>().InstancePerRequest();

            var container = builder.Build();
            int count = 0;
            using (var scope = container.BeginLifetimeScope("myrequest"))
            {
                while (count < 10)
                {
                    var r = scope.Resolve<IMyResource>(); // Out of memory!
                    Console.WriteLine(r.GetHashCode());
                    using (var scope2 = scope.BeginLifetimeScope())
                    {
                        var r1 = scope2.Resolve<IMyResource>();
                        Console.WriteLine($"r1:{r1.GetHashCode()}");
                    }
                    count++;
                }
                Console.WriteLine("scope end");
            }
            using (var scope = container.BeginLifetimeScope("myrequest"))
            {
                count = 0;
                while (count < 10)
                {
                    var r = container.Resolve<IMyResource>(); // Out of memory!
                    Console.WriteLine(r.GetHashCode());
                    count++;
                }
                Console.WriteLine("scope end");
            }



            Console.ReadLine();

        }
    }
    interface IMyResource
    {
    }

    class MyResource : IMyResource, IDisposable
    {
        public int MyProperty { get; set; }
        public string MyProperty1 { get; set; }
        public string MyProperty2 { get; set; }
        public string MyProperty3 { get; set; }
        public string MyProperty4 { get; set; }
        public string MyProperty5 { get; set; }
        public string MyProperty6 { get; set; }
        public string MyProperty7 { get; set; }
        public void Dispose()
        {

        }
    }
}
