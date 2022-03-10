using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPriority
{
    class TimerSynchron
    {
        public static void Timer1()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Class1.Cycle();
            sw.Stop();
            Console.WriteLine("\nID="+Thread.CurrentThread.ManagedThreadId +" time=" + sw.ElapsedMilliseconds);
        }
    }
}
