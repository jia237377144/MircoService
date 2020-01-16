#region << 版 本 注 释 >>
/*
     * ========================================================================
     * Copyright Notice © 2010-2014 TideBuy.com All rights reserved .
     * ========================================================================
     * 机器名称： 
     * 文件名：  BaseTimerCycleEnginee 
     * 版本号：  V1.0.0.0 
     * 创建人：  王云鹏 
     * 创建时间：2015/9/23
     * 描述    : BaseTimerCycleEnginee 按照时间间隔方式循环引擎
     * =====================================================================
     * 修改时间：2015/9/23
     * 修改人  ：  
     * 版本号  ： V1.0.0.0 
     * 描述    ：
*/
#endregion
using System;
using System.Threading;

namespace TLZ.CycleEngine
{
    /// <summary>
    /// BaseTimerCycleEnginee 按照时间间隔方式循环引擎，循环引擎直接继承它并实现DoDetect方法即可。
    /// </summary>
    public abstract class BaseTimerCycleEnginee : ICycleEnginee
    {
        private Timer _timer = null;
        /// <summary>
        /// 每次轮训的时间间隔(单位：秒)
        /// </summary>
        private int _detectSpanInSecs = 0;
        /// <summary>
        /// 轮训任务是否运行
        /// </summary>
        private bool _isRunning = false;

        protected abstract bool DoDetect();

        public BaseTimerCycleEnginee()
        {
        }

        public virtual void Start()
        {
            if (this._timer == null)
            {
                this._timer = new Timer(new TimerCallback(this.Worker), null, 0, this._detectSpanInSecs * 1000);
            }
        }

        public virtual void Stop()
        {
            this._timer.Dispose();
            this._timer = null;
        }

        private void Worker(Object obj)
        {
            try
            {
                this.DoDetect();
            }
            catch (Exception ex)
            {
                this.OnEngineStopped(new EngineeStoppedEventArgs(ex));
                this._timer.Dispose();
                this._timer = null;
            }
        }

        /// <summary>
        /// 轮训任务是否运行
        /// </summary>
        public bool IsRunning
        {
            get { return this._isRunning; }
        }

        /// <summary>
        /// 每次轮训的时间间隔(单位：秒)
        /// </summary>
        public int DetectSpanInSecs
        {
            get
            {
                return this._detectSpanInSecs;
            }
            set
            {
                this._detectSpanInSecs = value;
            }
        }

        public event EventHandler<EngineeStoppedEventArgs> EngineStopped;

        private void OnEngineStopped(EngineeStoppedEventArgs e)
        {
            if (this.EngineStopped != null)
                this.EngineStopped(this, e);
        }
    }
}
