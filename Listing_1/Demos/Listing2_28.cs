using System;

namespace CertifV2.Demos
{
    class Listing2_28
    {
        class Customer
        {
            private string _nameValue;

            public string Name
            {
                get
                {
                    return _nameValue;
                }
                set
                {
                    if (value == "")
                        throw new Exception("Invalid customer name");
                    _nameValue = value;
                }
            }
        }

        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.Name = "Rob";
            Console.WriteLine("Customer name: {0}", c.Name);

            Console.WriteLine("The following statement will throw an exception. Press any key to continue...");
            Console.ReadKey();
            // the following statement will throw an exception
            c.Name = "";
        }
    }
}
