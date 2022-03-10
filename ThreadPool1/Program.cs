using System;
using System.Diagnostics;

namespace ThreadPool1
{
    class Program
    {
        static void Main(string[] args)
        {
            //այս for-ը կոմպիլիացիայի համար է ,առանց սրա սխալ արդյունք է տալիս։
            for (int i = 0; i < 10; i++)
            {
                OnlyThreadMethod.ThreadMethod();
                OnlyThreadPoolMethod.PoolMethod();
            }

            Stopwatch sw = new Stopwatch();
            Console.WriteLine("We use the ThreadMethod");
            sw.Start();
            OnlyThreadMethod.ThreadMethod();
            sw.Stop();
            Console.WriteLine("Time consumed by ThreadMethod is :" + sw.ElapsedTicks.ToString());
            sw.Reset();

            Console.WriteLine("We use the ThreadPoolMethod");
            sw.Start();
            OnlyThreadPoolMethod.PoolMethod();
            sw.Stop();
            Console.WriteLine("Time consumed by ThreadPoolMethod is :" + sw.ElapsedTicks.ToString());

        }
    }
}
