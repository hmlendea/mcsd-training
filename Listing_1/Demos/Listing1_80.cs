using System;

namespace CertifV2.Demos
{
    class Listing1_80
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("I think you should know that I'm feeling very depressed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
