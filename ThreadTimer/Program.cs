using System;
using System.Diagnostics;
using System.Threading;

namespace ThreadTimer
{
    class Program
    {
        static void Main(string[] args)
        {

            Cycle cycle = new Cycle();
            Thread.CurrentThread.Name = "Main thread";
            string choose = Validation.ChooseValidation();
            Stopwatch sw = new Stopwatch();
            if (choose == "1")
            {
                sw.Start();
                Cycle.ForCicly();
                sw.Stop();
                Console.WriteLine("\nID=" + Thread.CurrentThread.ManagedThreadId + "time=" + sw.ElapsedTicks.ToString());
                sw.Reset();
            }
            else
            {
                sw.Start();
                ThreadStart threadStart = new ThreadStart(Cycle.ForCicly);
                Thread thread = new Thread(threadStart);
                thread.Name = "Second thread";
                thread.Start();
                thread.Join();
                sw.Stop();
                Console.WriteLine("\nID=" + thread.ManagedThreadId + "time=" + sw.ElapsedTicks.ToString());
                sw.Reset();
            }


        }
    }
}
