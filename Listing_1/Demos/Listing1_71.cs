using System;

namespace CertifV2.Demos
{
    class Listing1_71
    {
        delegate int IntOperation(int a, int b);

        static int Add(int a, int b)
        {
            Console.WriteLine("Add called");
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            Console.WriteLine("Subtract called");
            return a - b;
        }

        static void Main(string[] args)
        {
            // Explicitly create the delegate
            IntOperation op = new IntOperation(Add);
            Console.WriteLine(op(2, 2));

            // Delegate is created automatically
            // from method
            op = Subtract;
            Console.WriteLine(op(2, 2));
        }
    }
}
