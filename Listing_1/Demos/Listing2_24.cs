using System;

namespace CertifV2.Demos
{
    class Listing2_24
    {
        class MessageDisplay
        {
            public void DisplayMessage(string message)
            {
                Console.WriteLine(message);
            }
        }

        static void Main(string[] args)
        {
            MessageDisplay m = new MessageDisplay();
            m.DisplayMessage("Hello world");

            dynamic d = new MessageDisplay();
            d.Banana("hello world");
        }
    }
}
