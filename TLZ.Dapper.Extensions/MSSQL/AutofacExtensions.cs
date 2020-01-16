#region << 版 本 注 释 >>
/*
     * ========================================================================
     * Copyright Notice  2010-2019 TideBuy.com All rights reserved .
     * ========================================================================
     * 机器名称：USER-JLFFS1KMVG 
     * 文件名：  AutofacExtensions 
     * 版本号：  V1.0.0.0 
     * 创建人：  wangyunpeng 
     * 创建时间： 2019/11/15 9:13:32 
     * 描述    :
     * =====================================================================
     * 修改时间：2019/11/15 9:13:32 
     * 修改人  ： wangyunpeng
     * 版本号  ： V1.0.0.0 
     * 描述    ：
*/
#endregion
using Autofac;
using Dapper.Extensions;
using System;

namespace TLZ.Dapper.Extensions.MSSQL
{
    public static class AutofacExtensions
    {
        public static ContainerBuilder AddDapperForMSSQL(this ContainerBuilder container, string connectionName = "DefaultConnection", string serviceKey = null, bool enableMasterSlave = false)
        {
            container.AddDapper<MsSqlDapper>(connectionName, serviceKey, enableMasterSlave);
            return container;
        }

        public static ContainerBuilder AddDapperForMSSQL(this ContainerBuilder container, Action<DapperBuilder> builder)
        {
            var configure = new DapperBuilder();
            builder?.Invoke(configure);
            container.AddDapper<MsSqlDapper>(configure.ConnectionName, configure.ServiceKey, configure.EnableMasterSlave);
            return container;
        }
    }
}
