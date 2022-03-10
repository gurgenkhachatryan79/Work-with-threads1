using System;
using System.Threading;

namespace ThreadBackgroundForeground
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main thread";
            Console.WriteLine(Thread.CurrentThread.Name + " ID=" + Thread.CurrentThread.ManagedThreadId + " is in");
            Thread thread = new Thread(new Class1().Method1);
            thread.Start();
            thread.IsBackground = true;
            Cycle.ForCycle(20, 200, '*');
        }
    }
}
