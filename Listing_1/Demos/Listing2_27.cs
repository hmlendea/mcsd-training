using System;

namespace CertifV2.Demos
{
    class Listing2_27
    {
        class Customer
        {
            public string Name;
        }

        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.Name = "Rob";
            Console.WriteLine("Customer name: {0}", c.Name);
        }
    }
}
