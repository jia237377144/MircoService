using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperDemo
{
    /// <summary>
    /// https://www.cnblogs.com/ITWeiHan/p/11614704.html
    /// </summary>
    public static class DaperDynamic
    {

        public static void Run(string connString)
        {
            using (var connection = new MySqlConnection(connString))
            {
                connection.Open();
                IEnumerable<dynamic> user_Infos = connection.Query("SELECT * FROM user_info ORDER BY ID DESC LIMIT 10");

                foreach (var user in user_Infos)
                {
                    System.Console.WriteLine($"Email:{user.Email}");
                }
            }
        }

        public static IEnumerable<dynamic> Query(this IDbConnection cnn,string sql)
        {
            using(var command=cnn.CreateCommand())
            {
                command.CommandText = sql;
                using(var reader =command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        yield return reader.CastToDynamic();
                    }
                }
            }
        }

        public static IEnumerable<int> yieldTest(int count)
        {
            for(int i=0;i<count;i++)
            {
                yield return i;
            }
        }

        private static dynamic CastToDynamic(this IDataReader reader)
        {
            ExpandoObject expandoObject = new ExpandoObject();
            IDictionary<string, object> dict = expandoObject;

            for (int i=0;i<reader.FieldCount;i++)
            {
                dict.Add(reader.GetName(i), reader[i]);
            }
            return dict;

        }

    }
}
