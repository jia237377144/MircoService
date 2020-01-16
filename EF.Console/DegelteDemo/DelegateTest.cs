using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace EF.Console.DegelteDemo
{

    public class DelegateTest
    {
        public delegate int AddDelegate(int x, int y);
        public static void Run()
        {
            System.Console.WriteLine("Client application started!\n");
            Thread.CurrentThread.Name = "Main Thread";

            Calculator cal = new Calculator();
            AddDelegate del = new AddDelegate(cal.Add);
            string data = "Any data you want to pass.";
            AsyncCallback callBack = new AsyncCallback(OnAddComplete);
            del.BeginInvoke(2, 5, callBack, data);//异步调用方法
            //做些事情,模拟需要执行3秒钟
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(i));
                System.Console.WriteLine("{0} : Client executed {1} second(s).", Thread.CurrentThread.Name, i);
            }
            System.Console.WriteLine("Press any key to exit...");
            System.Console.ReadKey();

        }

        static void OnAddComplete(IAsyncResult asyncResult)
        {
            AsyncResult result = (AsyncResult)asyncResult;

            var actionType = (AddDelegate)result.AsyncDelegate;
            string data = (string)result.AsyncState;
            int rtn = actionType.EndInvoke(asyncResult);
            System.Console.WriteLine("{0}: Result, {1};Data: {2}\n",
                Thread.CurrentThread.Name,
                rtn,
                data);

        }

    }

    public class Calculator
    {
        public int Add(int x, int y)
        {
            if (Thread.CurrentThread.IsThreadPoolThread)
            {
                Thread.CurrentThread.Name = "Pool Thread";
            }
            System.Console.WriteLine("Method invoked!");

            //执行某些事情,模拟需要执行两秒钟
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(i));
                System.Console.WriteLine("{0}: Add executed {1} seconds", Thread.CurrentThread.Name, i);
            }
            System.Console.WriteLine("Method complete!");
            return x + y;
        }
    }

}
