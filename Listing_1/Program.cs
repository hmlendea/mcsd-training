using System;
using System.Linq;
using System.Reflection;

namespace CertifV2
{
    class Program
    {
        public static void Main(string[] args)
        {
            PrintCommandsList();

            while (true)
            {
                AskToOpenListing(args);
            }
        }

        static void PrintCommandsList()
        {
            Console.WriteLine();
            Console.WriteLine("=== Skill 1.1: Implement multithreading and asynchronous processing ===");
            Console.WriteLine("1.1 : Parallel Invoke");
            Console.WriteLine("1.2 : Parallel ForEach");
            Console.WriteLine("1.3 : Parallel For");
            Console.WriteLine("1.4a: Parallel For with Stop");
            Console.WriteLine("1.4b: Parallel For with Break");
            Console.WriteLine("1.5 : Parallel LINQ");
            Console.WriteLine("1.8 : Parallel LINQ with AsSequential and Take");

            Console.WriteLine();
            Console.WriteLine("=== Skill 1.2: Manage multithreading ===");
            Console.WriteLine("1.41: Single task summing");
            Console.WriteLine("1.42: Bad task interaction");
            Console.WriteLine("1.46: Sequential locking");

            Console.WriteLine();
            Console.WriteLine("=== Skill 1.4: Create and implement events and callbacks ===");
            Console.WriteLine("1.65: Publish and subscribe");
            Console.WriteLine("1.66: Unsubscribing");
            Console.WriteLine("1.67: Event based alarm");
            Console.WriteLine("1.68: EventHandler alarm");
            Console.WriteLine("1.69: EventHandler data");
            Console.WriteLine("1.70: Aggregating exceptions");
            Console.WriteLine("1.71: Create delegates");

            Console.WriteLine();
            Console.WriteLine("=== Skill 1.5: Implement exception handling ===");
            Console.WriteLine("1.76: Try catch");
            Console.WriteLine("1.77: Exception object");
            Console.WriteLine("1.78: Exception types");
            Console.WriteLine("1.79: The finally block");
            Console.WriteLine("1.80: Throwing an exception");
            Console.WriteLine("1.81: Custom exceptions");

            Console.WriteLine();
            Console.WriteLine("=== Skill 2.2: Consuming types ===");
            Console.WriteLine("2.23: Type conversion");
            Console.WriteLine("2.24: Bad dynamic code");
            Console.WriteLine("2.25: Using dynamic variables");

            Console.WriteLine();
            Console.WriteLine("=== Skill 2.3: Enforce encapsulation ===");
            Console.WriteLine("2.27: Public data members");
            Console.WriteLine("2.28: Using a property");
            Console.WriteLine("2.29: Creating accessor methods");

            Console.WriteLine();
            Console.WriteLine("q / quit / exit: Exit the program");
            Console.WriteLine("h / help: Print the commands list");
        }

        static void AskToOpenListing(string[] args)
        {
            Console.WriteLine();
            Console.Write("> ");
            string option = Console.ReadLine();
            Console.WriteLine();

            if (new string[] { "q", "quit", "exit" }.Any(x => x.Equals(option)))
            {
                Environment.Exit(0);
            }
            else if (new string[] { "h", "help" }.Any(x => x.Equals(option)))
            {
                PrintCommandsList();
            }
            else
            {
                TryExecuteListing(option, args);
            }
        }

        static void TryExecuteListing(string listing, string[] args)
        {
            try
            {
                ExecuteListing(listing, args);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        static void ExecuteListing(string listing, string[] args)
        {
            string listingClassFullName = $"CertifV2.Demos.Listing{listing.Replace('.', '_')}";
            Console.WriteLine($"Opening '{listingClassFullName}'...");
            Console.WriteLine();

            Type listingClass = Type.GetType(listingClassFullName);
            MethodInfo method = listingClass.GetMethod("Main", BindingFlags.Static | BindingFlags.NonPublic);

            method.Invoke(listingClass, new object[] { args });
        }
    }
}
