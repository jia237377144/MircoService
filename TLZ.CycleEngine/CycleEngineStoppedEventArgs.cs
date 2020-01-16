#region << 版 本 注 释 >>
/*
     * ========================================================================
     * Copyright Notice © 2010-2014 TideBuy.com All rights reserved .
     * ========================================================================
     * 机器名称： 
     * 文件名：  EngineeStoppedEventArgs 
     * 版本号：  V1.0.0.0 
     * 创建人：  王云鹏 
     * 创建时间：2015/9/23
     * 描述    : EngineeStoppedEventArgs 当引擎由运行变为停止状态时，参数类型。
     * =====================================================================
     * 修改时间：2015/9/23
     * 修改人  ：  
     * 版本号  ： V1.0.0.0 
     * 描述    ：
*/
#endregion
using System;

namespace TLZ.CycleEngine
{
    /// <summary>
    /// EngineeStoppedEventArgs 当引擎由运行变为停止状态时，参数类型。
    /// </summary>
    public class EngineeStoppedEventArgs : EventArgs
    {
        private Exception _Exception;

        public EngineeStoppedEventArgs(Exception exception)
        {
            this._Exception = exception;
        }

        public Exception Exception
        {
            get { return this._Exception; }
        }
    }
}
