using EF.Console.Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Z.Dapper.Plus;

namespace EF.Console.DapperFilterTest
{
    public class FilterTest
    {
        private const string CONNECTION_STRING = "server=38.123.97.215;uid=tb;pwd=fwlql0kLc61x;database=Tidebuy";

        public static void Run()
        {
            TB_ProductList_Filter filter = new TB_ProductList_Filter
            {
                //ID = 18192975,
                //Title = "Chicgoo",
                //AddDate = new DapperFilter.SpecificFieldFilter.RangeFieldFilter<DateTime>(DateTime.Parse("2019-11-26 20:48:23.300"), DateTime.Parse("2019-11-27 20:48:23.300")),
                PmsCategoryID = new List<int> { 665, 678 },
                //Price = 52.5M
            };


            //using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            //{
            //    var filterator = filter.GetFilterator(conn);
            //    for (int i = 0; i < 10; i++)
            //    {
            //        filterator.ToList();
            //    }


            //    var dataCount = filterator.Count();
            //    System.Console.WriteLine($"Count:{dataCount}");
            //}

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {


                conn.Open();

                string email = "0rgd1345@ezweb.ne.jp' OR'1'='1";
                string sql = $"SELECT COUNT(1) FROM dbo.TB_Users WHERE Email=@EMAIL";


                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@EMAIL", Value = email });
                var obj = cmd.ExecuteScalar();

                int dataCount = Convert.ToInt32(obj);


                System.Console.WriteLine($"Count:{dataCount}");
            }


        }


    }
}
