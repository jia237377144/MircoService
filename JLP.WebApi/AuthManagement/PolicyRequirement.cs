using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JLP.WebApi.AuthManagement
{
    /// <summary>
    /// 权限承载实体
    /// </summary>
    public class PolicyRequirement : IAuthorizationRequirement
    {
        /// <summary>
        /// 用户权限集合
        /// </summary>
        public List<UserPermission> UserPermissions { get; private set; }
        /// <summary>
        /// 无权限action
        /// </summary>
        public string DeniedAction { get; set; }
        /// <summary>
        /// 构造
        /// </summary>
        public PolicyRequirement()
        {
            //没有权限则跳转到这个路由
            DeniedAction = new PathString("/api/auth/ForBidden");
            //用户有权限访问的路由配置,当然可以从数据库获取
            UserPermissions = new List<UserPermission>{
                new UserPermission
                {
                    Role = "admin",
                    PerssionUrls = new List<string> { "api/values/value2","api/values/value3" }
                },
                new UserPermission
                {
                    Role="user",
                    PerssionUrls = new List<string> { "api/values/value2" }

                }
            };
        }
    }
}
