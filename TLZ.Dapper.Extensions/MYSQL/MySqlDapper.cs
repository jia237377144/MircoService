#region << 版 本 注 释 >>
/*
     * ========================================================================
     * Copyright Notice  2010-2019 TideBuy.com All rights reserved .
     * ========================================================================
     * 机器名称：USER-JLFFS1KMVG 
     * 文件名：  MySqlDapper 
     * 版本号：  V1.0.0.0 
     * 创建人：  wangyunpeng 
     * 创建时间： 2019/11/15 9:22:24 
     * 描述    :
     * =====================================================================
     * 修改时间：2019/11/15 9:22:24 
     * 修改人  ： wangyunpeng
     * 版本号  ： V1.0.0.0 
     * 描述    ：
*/
#endregion
using Dapper.Extensions;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace TLZ.Dapper.Extensions.MYSQL
{
    public class MySqlDapper : BaseDapper
    {
        private ILogger<MySqlDapper> Logger { get; }

        public MySqlDapper(IServiceProvider service
            , ILogger<MySqlDapper> logger
            , string connectionName = "DefaultConnection"
            , bool enableMasterSlave = false
            , bool readOnly = false)
            : base(service, connectionName, enableMasterSlave, readOnly)
        {
            this.Logger = logger;
        }
        protected override IDbConnection CreateConnection(string connectionName)
        {
            this.Logger?.LogDebug($"CreateConnection(connectionName)");
            return GetConnection(connectionName, MySqlClientFactory.Instance);
        }
    }
}
