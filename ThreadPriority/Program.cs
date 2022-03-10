using System;
using System.Diagnostics;
using System.Threading;

namespace ThreadPriority
{
    class Program
    {
        static void Main(string[] args)
        {
            TimerSynchron.Timer1();

            Thread thread = new Thread(TimerSynchron.Timer1);
            thread.Priority
            thread.Start();

        }
    }
}
