using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPriority
{
    class Class1
    {
        public static void Cycle()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.Write(".");
            }
        }
    }
}
