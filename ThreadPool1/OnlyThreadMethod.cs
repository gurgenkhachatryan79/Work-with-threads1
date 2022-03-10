using System.Threading;

namespace ThreadPool1
{
    class OnlyThreadMethod
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(ClassTest.Test);
            }
        }
    }
}
