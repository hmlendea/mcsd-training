using System;

namespace CertifV2.Demos
{
    class Listing1_76
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter an integer: ");
                string numberText = Console.ReadLine();
                int result;
                result = int.Parse(numberText);
                Console.WriteLine("You entered {0}", result);
            }
            catch
            {
                Console.WriteLine("Invalid number entered");
            }
        }
    }
}
