#region << 版 本 注 释 >>
/*
     * ========================================================================
     * Copyright Notice  2010-2019 TideBuy.com All rights reserved .
     * ========================================================================
     * 机器名称：USER-JLFFS1KMVG 
     * 文件名：  DependencyInjectionExtensions 
     * 版本号：  V1.0.0.0 
     * 创建人：  wangyunpeng 
     * 创建时间： 2019/11/15 9:13:48 
     * 描述    :
     * =====================================================================
     * 修改时间：2019/11/15 9:13:48 
     * 修改人  ： wangyunpeng
     * 版本号  ： V1.0.0.0 
     * 描述    ：
*/
#endregion
using Dapper.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace TLZ.Dapper.Extensions.MSSQL
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddDapperForMSSQL(this IServiceCollection services)
        {
            return services.AddScoped<IDapper, MsSqlDapper>();
        }
    }
}
