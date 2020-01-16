using System;
#region << 版 本 注 释 >>
/*
     * ========================================================================
     * Copyright Notice © 2010-2014 TideBuy.com All rights reserved .
     * ========================================================================
     * 机器名称： 
     * 文件名：  IEngineCycle 
     * 版本号：  V1.0.0.0 
     * 创建人：  王云鹏 
     * 创建时间：2015/9/23
     * 描述    : ICycleAction 循环执行引擎动作
     * =====================================================================
     * 修改时间：2015/9/23
     * 修改人  ：  
     * 版本号  ： V1.0.0.0 
     * 描述    ：
*/
#endregion

namespace TLZ.CycleEngine
{
    /// <summary>
    /// ICycleAction 循环执行引擎动作
    /// </summary>
    public interface ICycleAction
    {
        /// <summary>
        /// EngineAction 执行引擎动作，返回false表示停止引擎。
        /// 注意，该方法不能抛出异常，否则会导致引擎停止运行（循环线程遭遇异常退出）。
        /// </summary>       
        bool EngineAction();
    }
}
