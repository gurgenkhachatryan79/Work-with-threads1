using System;
using System.Threading;

namespace ThreadTimer
{
    class Cycle
    {
        public static void ForCicly()
        {
            Console.WriteLine("\nId=" + Thread.CurrentThread.ManagedThreadId + " thread is in");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(10);
                Console.Write(i + 1 + " ");
            }
            Console.WriteLine("\nId=" + Thread.CurrentThread.ManagedThreadId + " thread is out");
        }
    }
}
