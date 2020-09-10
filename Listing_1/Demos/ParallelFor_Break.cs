﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Listing1.Demos
{
    class ParallelFor_Break
    {
        static void WorkOnItem(object item)
        {
            Console.WriteLine("Started working on: " + item);
            Thread.Sleep(100);
            Console.WriteLine("Finished working on: " + item);
        }

        public static void Start()
        {
            var items = Enumerable.Range(0, 500).ToArray();
            int processedItemsCount = 0;

            ParallelLoopResult result = Parallel.For(0, items.Count(), (int i, ParallelLoopState loopState) =>
            {
                if (i == 200)
                    loopState.Break();

                WorkOnItem(items[i]);
                processedItemsCount += 1;
            });

            Console.WriteLine("Completed: " + result.IsCompleted);
            Console.WriteLine("Items: " + result.LowestBreakIteration);
            Console.WriteLine("Processed Items: " + processedItemsCount);

            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }
    }
}
