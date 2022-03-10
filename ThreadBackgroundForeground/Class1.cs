using System;
using System.Threading;

namespace ThreadBackgroundForeground
{
    class Class1
    {
        public void Method1()
        {
            Thread.CurrentThread.Name = "Second thread";
            Console.WriteLine(Thread.CurrentThread.Name + " ID=" + Thread.CurrentThread.ManagedThreadId + " is in");
            Thread thread2 = new Thread(new Class2().Method2);
            thread2.Start();
            Cycle.ForCycle(20, 400, '+');
        }
    }
}
