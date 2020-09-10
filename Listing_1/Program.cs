using System;
using Listing1.Demos;

namespace Listing1
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenProgram(args);
        }

        static void OpenProgram(string[] args)
        {
            ListOptions();

            Console.Write("Make your choice: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1": ParallelInvoke.Start(); break;
                case "2": ParallelForEach.Start(); break;
                case "3": ParallelFor.Start(); break;
                case "4a": ParallelFor_Stop.Start(); break;
                case "4b": ParallelFor_Break.Start(); break;
                case "5": ParallelLinq.Start(); break;

                default:
                    OpenProgram(args);
                    break;
            }
        }

        static void ListOptions()
        {
            Console.WriteLine("1  = Parallel Invoke");
            Console.WriteLine("2  = Parallel ForEach");
            Console.WriteLine("3  = Parallel For");
            Console.WriteLine("4a = Parallel For with Stop");
            Console.WriteLine("4b = Parallel For with Break");
            Console.WriteLine("5  = Parallel LINQ");
        }
    }
}