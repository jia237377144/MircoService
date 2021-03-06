#region << 版 本 注 释 >>
/*
     * ========================================================================
     * Copyright Notice © 2010-2014 TideBuy.com All rights reserved .
     * ========================================================================
     * 机器名称： 
     * 文件名：  ICycleEnginee 
     * 版本号：  V1.0.0.0 
     * 创建人：  王云鹏 
     * 创建时间：2015/9/23
     * 描述    : ICycleEngine 在后台线程中进行间隔循环的引擎
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
    /// TLZ.CycleEngine.dll此类库是最简单最好用的执行定时任务代码类目。wangyunpeng
    /// ICycleEngine 在后台线程中进行间隔循环的引擎
    /// </summary>
    public interface ICycleEnginee
    {
        /// <summary>
        /// Start 启动后台引擎线程
        /// </summary>
        void Start();

        /// <summary>
        /// Stop 停止后台引擎线程，只有当线程安全退出后，该方法才返回
        /// </summary>
        void Stop();

        /// <summary>
        /// IsRunning 引擎是否运行中
        /// </summary>
        bool IsRunning { get; }

        /// <summary>
        /// DetectSpanInSecs 引擎进行轮询的间隔(单位：秒)，DetectSpanInSecs=0，表示无间隙运作引擎；DetectSpanInSecs小于0则表示不使用引擎
        /// </summary>
        int DetectSpanInSecs { get; set; }

        /// <summary>
        /// OnEngineStopped 当引擎由运行变为停止状态时，将触发此事件。如果是异常停止，则事件参数为异常对象，否则，事件参数为null。
        /// </summary>
        event EventHandler<EngineeStoppedEventArgs> EngineStopped;
    }    
}
