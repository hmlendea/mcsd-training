using System;
using System.Linq;

namespace CertifV2.Demos
{
    class Listing1_41
    {
        static int[] items = Enumerable.Range(0, 50000001).ToArray();

        static void Main(string[] args)
        {
            long total = 0;

            for (int i = 0; i < items.Length; i++)
            {
                total = total + items[i];
            }

            Console.WriteLine("The total is: {0}", total);
        }
    }
}
