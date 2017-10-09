using System;

// SAMPLE: Boxing and unboxing

namespace CertificationTraining.Workspace.Chapter2
{
    public static class BoxingAndUnboxing
    {
        public static void VerboseRun()
        {
            int a = 873;
            object obj = a;
            int b = (int)obj;

            Console.WriteLine($"int a = {a};");
            Console.WriteLine($"object obj = a;");
            Console.WriteLine($"int b = (int)obj;");
            Console.WriteLine();

            Console.WriteLine($"obj.GetType() = {obj.GetType()}");
            Console.WriteLine($"b = {b}");
        }
    }
}
