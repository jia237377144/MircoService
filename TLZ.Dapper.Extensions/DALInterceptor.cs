#region << 版 本 注 释 >>
/*
     * ========================================================================
     * Copyright Notice  2010-2019 TideBuy.com All rights reserved .
     * ========================================================================
     * 机器名称：USER-JLFFS1KMVG 
     * 文件名：  DALInterceptor 
     * 版本号：  V1.0.0.0 
     * 创建人：  wangyunpeng 
     * 创建时间： 2019/11/19 10:21:50 
     * 描述    :
     * =====================================================================
     * 修改时间：2019/11/19 10:21:50 
     * 修改人  ： wangyunpeng
     * 版本号  ： V1.0.0.0 
     * 描述    ：
*/
#endregion
using Castle.DynamicProxy;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace TLZ.Dapper.Extensions
{
    public class DALInterceptor : IInterceptor
    {
        /// <summary>
        /// Account_AdminDAL 日志对象
        /// </summary>
        private ILogger<DALInterceptor> Logger { get; }

        public DALInterceptor(ILogger<DALInterceptor> logger)
        {
            this.Logger = logger;
        }
        public void Intercept(IInvocation invocation)
        {
            string methodName = invocation.TargetType.FullName + "." + invocation.Method.Name;
            var args = string.Join(", ", invocation.Arguments.Select(arg => (arg ?? string.Empty).ToString()).ToArray());
            this.Logger.LogInformation(
                string.Format("正在调用方法 \"{0}\"  参数是 {1}..."
              , methodName
              , args)
            );
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            invocation.Proceed();
            stopwatch.Stop();
            string time = stopwatch.Elapsed.ToString(@"s\.fff");
            this.Logger.LogInformation(string.Format("\"{0}\" 方法执行完毕，用时：{1} 秒，返回结果：{2}", methodName, time, invocation.ReturnValue));
        }
    }
}
