using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JLP.WebApi.AuthManagement
{
    public class UserPermission
    {
        /// <summary>
        /// 角色
        /// </summary>
        public string Role { get; set; }
        /// <summary>
        /// 请求Url
        /// </summary>
        public List<string> PerssionUrls { get; set; }
    }
}
