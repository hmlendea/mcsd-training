using System;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace CertifV2.Demos
{
    class ParallelForEach
    {
        static void WorkOnItem(object item)
        {
            Console.WriteLine("Started working on: " + item);
            Thread.Sleep(100);
            Console.WriteLine("Finished working on: " + item);
        }

        public static void Start()
        {
            var items = Enumerable.Range(0, 500);
            Parallel.ForEach(items, item =>
            {
                WorkOnItem(item);
            });
        }
    }
}
