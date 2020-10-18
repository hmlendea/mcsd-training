using System;
using System.Threading.Tasks;
using System.Threading;

namespace CertifV2.Demos
{
    class ParallelInvoke
    {
        static void Task1()
        {
            Console.WriteLine("Task 1 starting");
            Thread.Sleep(2000);
            Console.WriteLine("Task 1 ending");
        }

        static void Task2()
        {
            Console.WriteLine("Task 2 starting");
            Thread.Sleep(1000);
            Console.WriteLine("Task 2 ending");
        }

        public static void Start()
        {
            Parallel.Invoke(() => Task1(), () => Task2());
        }
    }
}
