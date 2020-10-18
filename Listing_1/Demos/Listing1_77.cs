﻿using System;

namespace CertifV2.Demos
{
    class Listing1_77
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
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("Stacktrace: " + ex.StackTrace);
                Console.WriteLine("HelpLink: " + ex.HelpLink);
                Console.WriteLine("TargetSite: " + ex.TargetSite);
                Console.WriteLine("Source:" + ex.Source);
            }
        }
    }
}
