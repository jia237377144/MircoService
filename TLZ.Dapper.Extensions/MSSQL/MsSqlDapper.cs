﻿#region << 版 本 注 释 >>
/*
     * ========================================================================
     * Copyright Notice  2010-2019 TideBuy.com All rights reserved .
     * ========================================================================
     * 机器名称：USER-JLFFS1KMVG 
     * 文件名：  MsSqlDapper 
     * 版本号：  V1.0.0.0 
     * 创建人：  wangyunpeng 
     * 创建时间： 2019/11/15 9:14:04 
     * 描述    :
     * =====================================================================
     * 修改时间：2019/11/15 9:14:04 
     * 修改人  ： wangyunpeng
     * 版本号  ： V1.0.0.0 
     * 描述    ：
*/
#endregion
using Dapper;
using Dapper.Extensions;
using Microsoft.Extensions.Logging;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace TLZ.Dapper.Extensions.MSSQL
{
    public class MsSqlDapper : BaseDapper
    {
        private ILogger<MsSqlDapper> Logger { get; }
        public MsSqlDapper(IServiceProvider service
            , ILogger<MsSqlDapper> logger
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
            return GetConnection(connectionName, SqlClientFactory.Instance);
        }
        public override async Task<PageResult<TReturn>> QueryPageAsync<TReturn>(string countSql, string dataSql, int pageindex, int pageSize, object param = null, int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default, string cacheKey = default)
        {
            if (pageindex < 1)
                throw new ArgumentException("The pageindex cannot be less then 1.");
            if (pageSize < 1)
                throw new ArgumentException("The pageSize cannot be less then 1.");
            var pars = new DynamicParameters();
            if (param != null)
                pars.AddDynamicParams(param);

            pars.AddDynamicParams(new
            {
                TakeStart = (pageindex - 1) * pageSize + 1,
                TakeEnd = pageindex * pageSize,
                Skip = (pageindex - 1) * pageSize,
                Take = pageSize
            });

            var sql = $"{countSql}{(countSql.EndsWith(";") ? "" : ";")}{dataSql}";
            return await CommandExecuteAsync(enableCache, async () =>
            {
                using (var multi = await Conn.Value.QueryMultipleAsync(sql, pars, Transaction, commandTimeout))
                {
                    var count = (await multi.ReadAsync<int>()).FirstOrDefault();
                    var data = (await multi.ReadAsync<TReturn>()).ToList();
                    var result = new PageResult<TReturn>
                    {
                        TotalCount = count,
                        Page = pageindex,
                        PageSize = pageSize,
                        Contents = data
                    };
                    result.TotalPage = result.TotalCount % pageSize == 0
                        ? result.TotalCount / pageSize
                        : result.TotalCount / pageSize + 1;
                    if (result.Page > result.TotalPage)
                        result.Page = result.TotalPage;
                    return result;
                }
            }, sql, pars, cacheKey, cacheExpire, pageindex, pageSize);
        }

        public override async Task<PageResult<dynamic>> QueryPageAsync(string countSql, string dataSql, int pageindex, int pageSize, object param = null,
            int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default, string cacheKey = default)
        {
            if (pageindex < 1)
                throw new ArgumentException("The pageindex cannot be less then 1.");
            if (pageSize < 1)
                throw new ArgumentException("The pageSize cannot be less then 1.");
            var pars = new DynamicParameters();
            if (param != null)
                pars.AddDynamicParams(param);

            pars.AddDynamicParams(new
            {
                TakeStart = (pageindex - 1) * pageSize + 1,
                TakeEnd = pageindex * pageSize,
                Skip = (pageindex - 1) * pageSize,
                Take = pageSize
            });
            var sql = $"{countSql}{(countSql.EndsWith(";") ? "" : ";")}{dataSql}";
            return await CommandExecuteAsync(enableCache, async () =>
            {
                using (var multi = await Conn.Value.QueryMultipleAsync(sql, pars, Transaction, commandTimeout))
                {
                    var count = (await multi.ReadAsync<int>()).FirstOrDefault();
                    var data = (await multi.ReadAsync()).ToList();
                    var result = new PageResult<dynamic>
                    {
                        TotalCount = count,
                        Page = pageindex,
                        PageSize = pageSize,
                        Contents = data
                    };
                    result.TotalPage = result.TotalCount % pageSize == 0
                        ? result.TotalCount / pageSize
                        : result.TotalCount / pageSize + 1;
                    if (result.Page > result.TotalPage)
                        result.Page = result.TotalPage;
                    return result;
                }
            }, sql, pars, cacheKey, cacheExpire, pageindex, pageSize);

        }

        public override PageResult<TReturn> QueryPage<TReturn>(string countSql, string dataSql, int pageindex, int pageSize, object param = null, int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default, string cacheKey = default)
        {
            if (pageindex < 1)
                throw new ArgumentException("The pageindex cannot be less then 1.");
            if (pageSize < 1)
                throw new ArgumentException("The pageSize cannot be less then 1.");
            var pars = new DynamicParameters();
            if (param != null)
                pars.AddDynamicParams(param);

            pars.AddDynamicParams(new
            {
                TakeStart = (pageindex - 1) * pageSize + 1,
                TakeEnd = pageindex * pageSize,
                Skip = (pageindex - 1) * pageSize,
                Take = pageSize
            });

            var sql = $"{countSql}{(countSql.EndsWith(";") ? "" : ";")}{dataSql}";
            return CommandExecute(enableCache, () =>
            {
                using (var multi = Conn.Value.QueryMultiple(sql, pars, Transaction, commandTimeout))
                {
                    var count = multi.Read<int>().FirstOrDefault();
                    var data = multi.Read<TReturn>().ToList();
                    var result = new PageResult<TReturn>
                    {
                        TotalCount = count,
                        Page = pageindex,
                        PageSize = pageSize,
                        Contents = data
                    };
                    result.TotalPage = result.TotalCount % pageSize == 0
                        ? result.TotalCount / pageSize
                        : result.TotalCount / pageSize + 1;
                    if (result.Page > result.TotalPage)
                        result.Page = result.TotalPage;
                    return result;
                }
            }, sql, pars, cacheKey, cacheExpire, pageindex, pageSize);
        }

        public override PageResult<dynamic> QueryPage(string countSql, string dataSql, int pageindex, int pageSize, object param = null,
            int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default, string cacheKey = default)
        {
            if (pageindex < 1)
                throw new ArgumentException("The pageindex cannot be less then 1.");
            if (pageSize < 1)
                throw new ArgumentException("The pageSize cannot be less then 1.");
            var pars = new DynamicParameters();
            if (param != null)
                pars.AddDynamicParams(param);

            pars.AddDynamicParams(new
            {
                TakeStart = (pageindex - 1) * pageSize + 1,
                TakeEnd = pageindex * pageSize,
                Skip = (pageindex - 1) * pageSize,
                Take = pageSize
            });

            var sql = $"{countSql}{(countSql.EndsWith(";") ? "" : ";")}{dataSql}";
            return CommandExecute(enableCache, () =>
            {
                using (var multi = Conn.Value.QueryMultiple(sql, pars, Transaction, commandTimeout))
                {
                    var count = multi.Read<int>().FirstOrDefault();
                    var data = multi.Read().ToList();
                    var result = new PageResult<dynamic>
                    {
                        TotalCount = count,
                        Page = pageindex,
                        PageSize = pageSize,
                        Contents = data
                    };
                    result.TotalPage = result.TotalCount % pageSize == 0
                        ? result.TotalCount / pageSize
                        : result.TotalCount / pageSize + 1;
                    if (result.Page > result.TotalPage)
                        result.Page = result.TotalPage;
                    return result;
                }
            }, sql, pars, cacheKey, cacheExpire, pageindex, pageSize);

        }
    }
}
