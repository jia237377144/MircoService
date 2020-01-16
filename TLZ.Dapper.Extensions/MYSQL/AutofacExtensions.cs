#region << 版 本 注 释 >>
/*
     * ========================================================================
     * Copyright Notice  2010-2019 TideBuy.com All rights reserved .
     * ========================================================================
     * 机器名称：USER-JLFFS1KMVG 
     * 文件名：  AutofacExtensions 
     * 版本号：  V1.0.0.0 
     * 创建人：  wangyunpeng 
     * 创建时间： 2019/11/15 9:19:43 
     * 描述    :
     * =====================================================================
     * 修改时间：2019/11/15 9:19:43 
     * 修改人  ： wangyunpeng
     * 版本号  ： V1.0.0.0 
     * 描述    ：
*/
#endregion
using Autofac;
using Dapper.Extensions;
using System;

namespace TLZ.Dapper.Extensions.MYSQL
{
    public static class AutofacExtensions
    {
        public static ContainerBuilder AddDapperForMySQL(this ContainerBuilder container, string connectionName = "DefaultConnection", string serviceKey = null, bool enableMasterSlave = false)
        {
            container.AddDapper<MySqlDapper>(connectionName, serviceKey, enableMasterSlave);
            return container;
        }


        public static ContainerBuilder AddDapperForMySQL(this ContainerBuilder container, Action<DapperBuilder> builder)
        {
            var configure = new DapperBuilder();
            builder?.Invoke(configure);
            container.AddDapper<MySqlDapper>(configure.ConnectionName, configure.ServiceKey, configure.EnableMasterSlave);
            return container;
        }
    }
}
