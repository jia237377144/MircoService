using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CommLib.LogService
{
    public static class ServiceRun
    {
        private static ServiceLogJob serviceLogJob;
        static ServiceRun()
        {
            serviceLogJob = new ServiceLogJob();
        }

        public static void Start()
        {
            serviceLogJob.Initialize();
        }

        public static void Stop()
        {
            serviceLogJob.Dispose();
        }

    }
}
