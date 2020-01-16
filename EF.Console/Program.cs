using Autofac;
using Autofac.Core;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
//using EF.Console.Dapper;
using EF.Console.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Web.Script.Serialization;
using EF.Console.DapperDemo;
using EF.Console.ExpressionDemo;
using EF.Console.EFDemo;
using System.IO;
using System.Diagnostics;
using System.Configuration;
using System.Data.Entity;
using EF.Console.StreamData;
using System.Threading.Tasks;
using TLZ.Redis;
using TLZ.Redis.Config;
using Newtonsoft.Json;
using EF.Console.DapperFilterTest;

namespace EF.Console
{
    class Program
    {
        private const string CONN_STRING = "Data Source=192.168.0.82;User Id=sa;Password=1234;Database=tbdress_website;Port=13306;default command timeout=100;Connection Timeout=30;Charset=utf8";

        static void Main(string[] args)
        {
            //System.Console.WriteLine($"PC Key Count: {StackExchangeRedisBus.DbSize("38.123.98.109:16379", 0)}");
            //System.Console.WriteLine($"M Key Count: {StackExchangeRedisBus.DbSize("38.123.98.109:16379", 1)}");
            //System.Console.WriteLine($"APP Key Count: {StackExchangeRedisBus.DbSize("38.123.98.109:16379", 2)}");
            //var server = StackExchangeRedisManager.GetServer("38.123.98.109:16379");
            //System.Console.WriteLine(JsonConvert.SerializeObject(server.Info()));

            FilterTest.Run();

            System.Console.ReadLine();
        }

    }

}

