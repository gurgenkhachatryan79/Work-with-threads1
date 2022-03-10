using System;
using System.Threading;

namespace ThreadBackgroundForeground
{
    class Cycle
    {
        public static void ForCycle(int iterationCount, int sleepTime, char ch)
        {
            for (int i = 0; i < iterationCount; i++)
            {
                Thread.Sleep(sleepTime);
                Console.Write(ch);
            }
            Console.WriteLine("\n" + Thread.CurrentThread.Name + " ID=" + Thread.CurrentThread.ManagedThreadId + " is out");
        }
    }
}
