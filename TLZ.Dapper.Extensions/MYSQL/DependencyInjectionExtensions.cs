#region << 版 本 注 释 >>
/*
     * ========================================================================
     * Copyright Notice  2010-2019 TideBuy.com All rights reserved .
     * ========================================================================
     * 机器名称：USER-JLFFS1KMVG 
     * 文件名：  DependencyInjectionExtensions 
     * 版本号：  V1.0.0.0 
     * 创建人：  wangyunpeng 
     * 创建时间： 2019/11/15 9:22:04 
     * 描述    :
     * =====================================================================
     * 修改时间：2019/11/15 9:22:04 
     * 修改人  ： wangyunpeng
     * 版本号  ： V1.0.0.0 
     * 描述    ：
*/
#endregion
using Dapper.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace TLZ.Dapper.Extensions.MYSQL
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddDapperForMySQL(this IServiceCollection services)
        {
            return services.AddScoped<IDapper, MySqlDapper>();
        }
    }
}
