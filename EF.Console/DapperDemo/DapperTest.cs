using EF.Console.Dapper;
using EF.Console.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.DapperDemo
{
    public class DapperTest
    {
        /// <summary>
        /// 1对1关系
        /// </summary>
        /// <param name="connStr"></param>
        public static void SingleToSingle(string connStr)
        {
            using (var connection = new MySqlConnection(connStr))
            {
                connection.Open();
                IEnumerable<dynamic> user_Infos = connection.Query<User_info, User_info_extend, User_info>("SELECT U.*,UE.Sex FROM user_info AS U INNER JOIN User_info_extend AS UE ON U.ID=UE.USERID ORDER BY U.ID DESC LIMIT 10 ",
                    (user, userExtend) => { user.UserInfoExtend = userExtend; return user; }, null, null, false, "UserID", null, System.Data.CommandType.Text
                    );

                foreach (var user in user_Infos)
                {
                    System.Console.WriteLine($"Email:{user.Email},Sex:{user.Sex}");
                }
            }
        }
    }
}
