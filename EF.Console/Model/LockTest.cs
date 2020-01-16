using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EF.Console.Model
{
    public class LockTest
    {
        private readonly static object _LockObj = new object();
        private static readonly Mutex mutex = new Mutex();
        static int i = 0;
        static int j = 0;
        static int m = 0;
        static int n = 0;
        [STAThread]
        public static void Run()
        {
            for (int k = 0; k < 100; k++)
            {
                System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(SetAdd));
                thread.Start();
                j++;
            }
            System.Console.WriteLine(j);
            System.Console.WriteLine(m);
            System.Console.WriteLine(n);
            System.Threading.Thread.Sleep(20000);
            System.Console.WriteLine(i);
        }
        private static void SetAdd()
        {
            for (int i = 0; i < 100; i++)
            {
                m++;
                Add();
                n++;
            }
        }
        public static void Add()
        {
            //TryEnter尝试获取锁，如果获取不到就会直接返回
            //if (System.Threading.Monitor.TryEnter(_LockObj))//lock(typeof(this))
            //{
            //    try
            //    {
            //        i++;

            //        System.Threading.Thread.Sleep(1);
            //    }

            //    finally

            //    {
            //        System.Threading.Monitor.Exit(_LockObj);
            //    }

            //}

            //Lock 将会一直等待，知道被释放
            //lock (_LockObj)
            //{
            //    i++;
            //    System.Threading.Thread.Sleep(1);
            //}


            mutex.WaitOne();
            i++;
            System.Threading.Thread.Sleep(1);
            mutex.ReleaseMutex();
        }
    }
}
