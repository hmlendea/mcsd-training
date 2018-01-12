using System;

namespace CertificationTraining.Workspace.Chapter2
{
    // SAMPLE: Flags enum
    // The values must be *manually* set to powers of 2.
    // It does not happen automatically, even tho we are using the Flags attribute.
    // Each bit position represents a flag. If we use powers of two, then they do not overlap.
    [Flags]
    enum MonthWithFlags
    {
        // There must always be an equivalent of the "None" value
        // This is because an AND operation with 0 will always result in 0 (false)
        None = 0,

        January = 1,
        February = 2,
        March = 4,
        April = 8,
        May = 16,
        June = 32,
        July = 64,
        August = 128,
        September = 256,
        October = 512,
        November = 1024,
        December = 2048
    }

    enum MonthWithoutFlags
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }

    public static class KeydEnumerations
    {
        public static void VerboseRun()
        {
            MonthWithFlags monthsWithFlags = (MonthWithFlags.January | MonthWithFlags.August);
            MonthWithoutFlags monthsWithoutFlags = (MonthWithoutFlags.January | MonthWithoutFlags.August);

            // The one without flags will equal "September" because 1 OR 8 = 9 (September)
            // 0001 OR 1000 = 1001, which is 9 in base 10

            Console.WriteLine("Both objects are set to `(MonthWithFlags.January | MonthWithFlags.August)`");
            Console.WriteLine($"monthsWithFlags = {monthsWithFlags.ToString()}");
            Console.WriteLine($"monthsWithoutFlags = {monthsWithoutFlags.ToString()}");
            Console.WriteLine();

            bool monthsWithFlagsContainsJanuary = (monthsWithFlags & MonthWithFlags.January) == MonthWithFlags.January;
            bool monthWithoutFlagsContainsJanuary = (monthsWithoutFlags & MonthWithoutFlags.January) == MonthWithoutFlags.January;

            Console.WriteLine($"monthsWithFlagsContainsJanuary = {monthsWithFlagsContainsJanuary}");
            Console.WriteLine($"monthWithoutFlagsContainsJanuary = {monthWithoutFlagsContainsJanuary}");

            Console.WriteLine("All possible combinations of values without FlagsAttribute:");
            for (int val = 0; val <= 12; val++)
            {
                Console.WriteLine("{0,3} - {1:G}", val, (MonthWithoutFlags)val);
            }
            
            Console.WriteLine("All possible combinations of values with FlagsAttribute:");
            for (int val = 0; val <= 12; val++)
            {
                Console.WriteLine("{0,3} - {1:G}", val, (MonthWithFlags)val);
            }
            Console.WriteLine("Et cetera...");
        }
    }
}
