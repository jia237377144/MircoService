using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JLP.WebApi.AuthManagement;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;

namespace JLP.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {


            //添加策略鉴权模式
            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("Permission", policy => policy.Requirements.Add(new PolicyRequirement()));
            //})
            //services.AddAuthentication(s =>
            //{
            //    //添加JWT Scheme
            //    s.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    s.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            //    s.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            ////添加jwt验证：
            //.AddJwtBearer(options =>
            //{
            //    options.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateLifetime = true,//是否验证失效时间
            //        ClockSkew = TimeSpan.FromSeconds(30),

            //        ValidateAudience = true,//是否验证Audience
            //        //ValidAudience = Const.GetValidudience(),//Audience
            //        //这里采用动态验证的方式，在重新登陆时，刷新token，旧token就强制失效了
            //        AudienceValidator = (m, n, z) =>
            //        {
            //            return m != null && m.FirstOrDefault().Equals(Const.ValidAudience);
            //        },
            //        ValidateIssuer = true,//是否验证Issuer
            //        ValidIssuer = Const.Domain,//Issuer，这两项和前面签发jwt的设置一致

            //        ValidateIssuerSigningKey = true,//是否验证SecurityKey
            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Const.SecurityKey))//拿到SecurityKey
            //    };
            //    options.Events = new JwtBearerEvents
            //    {
            //        OnAuthenticationFailed = context =>
            //        {
            //            //Token expired
            //            if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
            //            {
            //                context.Response.Headers.Add("Token-Expired", "true");
            //            }
            //            return Task.CompletedTask;
            //        }
            //    };
            //});
            ////注入授权Handler
            //services.AddSingleton<IAuthorizationHandler, PolicyHandler>();


            //添加jwt验证：
            services
                .AddAuthorization()
                .AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
           .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,//是否验证Issuer
                        ValidateAudience = true,//是否验证Audience
                        ValidateLifetime = true,//是否验证失效时间
                        ClockSkew = TimeSpan.FromSeconds(30),
                        ValidateIssuerSigningKey = true,//是否验证SecurityKey
                        ValidAudience = Const.Domain,//Audience
                        ValidIssuer = Const.Domain,//Issuer，这两项和前面签发jwt的设置一致
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Const.SecurityKey))//拿到SecurityKey
                    };
                    options.Events = new JwtBearerEvents
                    {
                        //在jwt验证之后，在Token验证通过后调用
                        OnTokenValidated = context =>
                        {
                            var authenticationResult = context.Request.Headers["webtest"].ToString();
                            if (authenticationResult == "true")
                            {
                                context.Response.Headers.Add("OnTokenValidated", "true");
                            }
                            else
                            {
                                context.Fail("No Perssion");
                            }
                            return Task.CompletedTask;
                        },
                        //jwt认证失败时触发,认证失败时调用
                        OnAuthenticationFailed = context =>
                        {
                            //Token expired
                            if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                            {
                                context.Response.Headers.Add("Token-Expired", "true");
                            }
                            return Task.CompletedTask;
                        },
                        OnMessageReceived = context =>
                        {
                            return Task.CompletedTask;
                        },
                        //任何认证（jwt和自定义）失败时触发,未授权时调用
                        OnChallenge = context =>
                        {
                            context.Response.Headers.Add("OnChallenge", "true");
                            return Task.CompletedTask;
                        }

                    };
                });
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            ///添加jwt验证
            app.UseAuthentication();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
