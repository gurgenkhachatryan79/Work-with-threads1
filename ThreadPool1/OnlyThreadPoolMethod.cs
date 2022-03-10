using System.Threading;

namespace ThreadPool1
{
    class OnlyThreadPoolMethod
    {
        public static void PoolMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(ClassTest.Test);
            }
        }
    }
}
