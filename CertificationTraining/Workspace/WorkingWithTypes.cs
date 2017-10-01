using System;

namespace CertificationTraining.Workspace
{
    public static class WorkingWithTypes
    {
        public static void CompareValueTypesAndTheirAliases()
        {
            int myInt; // doesn't assign any value - it will result in an error when trying to use it
            //Console.WriteLine($"myInt={myInt}");
            Console.WriteLine($"ERROR: Use of unassigned local variable '{nameof(myInt)}'");

            int myNewInt = new int(); // it will assign the default value
            Console.WriteLine($"myNewInt = {myNewInt}");

            Int32 myInt32 = new Int32(); // same as with int, it will assign the default value
            Console.WriteLine($"myInt32 = {myInt32}");
        }
    }
}
