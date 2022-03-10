using System;
using System.Threading;

namespace ThreadPriority1
{
    class Class1
    {
        public static void CycleThread1()
        {
            Console.WriteLine("\niD=" + Thread.CurrentThread.ManagedThreadId + " is in");
            for (int i = 0; i < 100; i++)
            {
                Console.Write(Thread.CurrentThread.ManagedThreadId);
            }
            Console.WriteLine("\niD=" + Thread.CurrentThread.ManagedThreadId + " is out");
        }
    }
}
