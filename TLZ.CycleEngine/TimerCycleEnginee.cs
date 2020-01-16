#region << 版 本 注 释 >>
/*
     * ========================================================================
     * Copyright Notice © 2010-2014 TideBuy.com All rights reserved .
     * ========================================================================
     * 机器名称： 
     * 文件名：  TimerCycleEnginee 
     * 版本号：  V1.0.0.0 
     * 创建人：  王云鹏 
     * 创建时间：2015/9/23
     * 描述    : TimerCycleEnginee 基于时间间隔的循环引擎
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
    /// TimerCycleEnginee 基于时间间隔的循环引擎
    /// </summary>
    public sealed class TimerCycleEnginee : BaseTimerCycleEnginee
    {
        private ICycleAction _engineActor;

        public TimerCycleEnginee(ICycleAction engineActor)
        {
            this._engineActor = engineActor;
        }

        protected override bool DoDetect()
        {
            return this._engineActor.EngineAction();
        }
    }
}
