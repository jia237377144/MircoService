#region << 版 本 注 释 >>
/*
     * ========================================================================
     * Copyright Notice © 2010-2014 TideBuy.com All rights reserved .
     * ========================================================================
     * 机器名称： 
     * 文件名：  QuickCycleEnginee 
     * 版本号：  V1.0.0.0 
     * 创建人：  王云鹏 
     * 创建时间：2015/9/23
     * 描述    : QuickCycleEnginee 通过组合使用的循环引擎
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
    /// QuickCycleEnginee 基于时间间隔+任务执行完成时间的循环引擎
    /// </summary>
    public sealed class TaskCycleEnginee : BaseTaskCycleEnginee
    {
        private ICycleAction _engineActor;

        public TaskCycleEnginee(ICycleAction engineActor)
        {
            this._engineActor = engineActor;
        }

        protected override bool DoDetect()
        {
            return this._engineActor.EngineAction();
        }
    }

}
