using System;
using System.Threading;

namespace ThreadBackgroundForeground
{
    class Class2
    {
        public void Method2()
        {
            Thread.CurrentThread.Name = "Third Thread";
            Console.WriteLine(Thread.CurrentThread.Name + " ID=" + Thread.CurrentThread.ManagedThreadId + " is in");
            Cycle.ForCycle(20, 400, '-');
        }
    }
}
