#region << 版 本 注 释 >>
/*
     * ========================================================================
     * Copyright Notice © 2010-2014 TideBuy.com All rights reserved .
     * ========================================================================
     * 机器名称： 
     * 文件名：  BaseCycleEnginee 
     * 版本号：  V1.0.0.0 
     * 创建人：  王云鹏 
     * 创建时间：2015/9/23
     * 描述    : BaseCycleEngine 基于时间间隔+任务执行完成时间，循环引擎直接继承它并实现DoDetect方法即可。
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
    /// BaseCycleEngine 基于时间间隔+任务执行完成时间，循环引擎直接继承它并实现DoDetect方法即可。
    /// </summary>
    public abstract class BaseTaskCycleEnginee : ICycleEnginee
    {
        /// <summary>
        /// 一次休息的时间
        /// </summary>
        private const int SLEEP_TIME = 1000;
        /// <summary>
        /// 轮训任务是否停止
        /// </summary>
        private volatile bool _isStop = true;
        /// <summary>
        /// 每次轮训的时间间隔(单位：秒)
        /// </summary>
        private int _detectSpanInSecs = 0;
        /// <summary>
        /// 总共休息的次数（每次休息SLEEP_TIME变量的值*totalSleepCount）
        /// 一共休息的时间=SLEEP_TIME*totalSleepCount
        /// </summary>
        private int _totalSleepCount = 0;
        /// <summary>
        /// 线程
        /// </summary>
        private Thread _thread;
        /// <summary>
        /// 轮训任务结束后执行的事件处理方法
        /// </summary>
        public event EventHandler<EngineeStoppedEventArgs> EngineStopped;

        /// <summary>
        /// DoDetect 每次循环时，引擎需要执行的核心动作。
        /// (1)该方法不允许抛出异常。
        /// (2)该方法中不允许调用BaseCycleEngine.Stop()方法，否则会导致死锁。
        /// </summary>
        /// <returns>返回值如果为false，表示退出引擎循环线程</returns>
        protected abstract bool DoDetect();

        /// <summary>
        /// 每次轮训的时间间隔(单位：秒)
        /// </summary>
        public int DetectSpanInSecs
        {
            get { return this._detectSpanInSecs; }
            set { this._detectSpanInSecs = value; }
        }

        /// <summary>
        /// 判断是否正在执行轮训任务
        /// </summary>
        public bool IsRunning
        {
            get
            {
                return !this._isStop;
            }
        }


        public BaseTaskCycleEnginee()
        {
            this._thread = new Thread(this.Worker) { IsBackground = true };
        }

        /// <summary>
        /// 轮训执行的任务
        /// </summary>
        private void Worker()
        {
            Exception exception = null;
            try
            {
                while (!this._isStop)
                {
                    if (!this.DoDetect())
                    {
                        this._isStop = true;
                        break;
                    }
                    #region 轮训过程中连续休息_totalSleepCount次，每次休息SLEEP_TIME时间
                    for (int i = 0; i < this._totalSleepCount; i++)
                    {
                        if (this._isStop)
                        {
                            break;
                        }
                        Thread.Sleep(BaseTaskCycleEnginee.SLEEP_TIME);
                    }
                    #endregion
                }
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            finally
            {
                this.OnEngineStopped(exception);
            }
        }

        private void OnEngineStopped(Exception exception)
        {
            this.Stop();
            if (this.EngineStopped != null)
            {
                this.EngineStopped(this, new EngineeStoppedEventArgs(exception));
            }
        }

        #region ICycleEngine 成员

        /// <summary>
        /// 启动执行轮训任务的方法
        /// </summary>
        public void Start()
        {
            if (this._detectSpanInSecs < 0)
            {
                return;
            }
            if (!this._isStop)
            {
                return;
            }
            this._totalSleepCount = this._detectSpanInSecs * 1000 / BaseTaskCycleEnginee.SLEEP_TIME;
            this._isStop = false;
            if (this._thread != null)
            {
                if ((this._thread.ThreadState & ThreadState.Unstarted) == ThreadState.Unstarted
                    || (this._thread.ThreadState & ThreadState.Stopped) == ThreadState.Stopped
                    || (this._thread.ThreadState & ThreadState.Aborted) == ThreadState.Aborted)
                {
                    this._thread.Start();
                }
            }
        }

        /// <summary>
        /// 停止正在执行的轮训方法
        /// </summary>
        public void Stop()
        {
            if (this._isStop)
            {
                return;
            }
            this._isStop = true;
            try
            {
                if ((this._thread.ThreadState & ThreadState.Unstarted) != ThreadState.Unstarted
                    && (this._thread.ThreadState & ThreadState.Stopped) != ThreadState.Stopped
                    && (this._thread.ThreadState & ThreadState.Aborted) != ThreadState.Aborted
                    && (this._thread.ThreadState & ThreadState.AbortRequested) != ThreadState.AbortRequested)
                {
                    this._thread.Abort();
                }
            }
            catch
            {
            }
        }

        #endregion
    }
}
