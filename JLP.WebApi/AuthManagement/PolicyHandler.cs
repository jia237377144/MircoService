using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JLP.WebApi.AuthManagement
{
    public class PolicyHandler : AuthorizationHandler<PolicyRequirement>, IAuthorizationRequirement
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PolicyRequirement requirement)
        {
            //赋值用户权限
            var userPermissions = requirement.UserPermissions;


            //请求Url
            var questUrl = (context.Resource as RouteEndpoint).RoutePattern.RawText.ToLowerInvariant();

            //是否经过验证
            var isAuthenticated = context.User.Identity.IsAuthenticated;

            if (isAuthenticated)
            {

                //用户名
                var role = context.User.Claims.SingleOrDefault(s => s.Type == ClaimTypes.Role).Value;
                var userPerssion = userPermissions.FirstOrDefault(p => p.Role == role);

                if (userPerssion != null)
                {
                    if (role == userPerssion.Role && userPerssion.PerssionUrls.Any(url => url.ToLowerInvariant() == questUrl))
                    {
                        context.Succeed(requirement);
                    }
                    else
                    {
                        //无权限跳转到拒绝页面
                        context.Fail();
                        //context.Response.Redirect(requirement.DeniedAction);
                    }
                }
                else
                {
                    //无权限跳转到拒绝页面
                    context.Fail();
                }
            }

            return Task.CompletedTask;
        }
    }
}
