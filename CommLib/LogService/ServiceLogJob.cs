using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLZ.CycleEngine;

namespace CommLib.LogService
{
    class ServiceLogJob : ICycleAction
    {
        private TaskCycleEnginee _taskCycleEngine = null;
        public bool EngineAction()
        {
            try
            {
                CreateLog();
            }
            catch (Exception ex)
            {

            }
            return true;
        }

        internal void Initialize()
        {
       
            this._taskCycleEngine = new TaskCycleEnginee(this);
            this._taskCycleEngine.DetectSpanInSecs =60;
            this._taskCycleEngine.Start();
        }


        public void CreateLog()
        {
            const string dir = "LOG_FILE_";
            string path = Path.GetFullPath("../../");
            string filePath = dir + DateTime.Now.ToString_yyyyMMdd();
            filePath = Path.Combine(path, filePath);
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            string fileName = DateTime.Now.ToString_yyyyMMddHHmm() + ".log";
            File.Create(Path.Combine(filePath, fileName));
        }

        /// <summary>
        /// 资源释放
        /// </summary>
        public void Dispose()
        {
            if (this._taskCycleEngine != null)
            {
                this._taskCycleEngine.Stop();
                this._taskCycleEngine = null;
            }
        }
    }
}
