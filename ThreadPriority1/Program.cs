using System;
using System.Threading;

namespace ThreadPriority1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Class1.CycleThread1);
            Thread thread2 = new Thread(Class1.CycleThread1);
            Console.WriteLine("ID Highest=" + thread1.ManagedThreadId);
            Console.WriteLine("ID Lowest=" + thread2.ManagedThreadId);
            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.Lowest;
            thread1.Start();
            thread2.Start();
        }
    }
}
