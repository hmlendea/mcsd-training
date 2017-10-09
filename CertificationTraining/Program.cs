using System;

using CertificationTraining.Workspace;
using CertificationTraining.Workspace.Chapter2;

namespace CertificationTraining
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*** MCSD Training samples and tests ***");
            Console.WriteLine();

            //WorkingWithTypes.CompareValueTypesAndTheirAliases();
            //WorkingWithTypes.UsingValueTypes();
            //WorkingWithTypes.TestBookStruct();
            //WorkingWithTypes.TestStudentClass();
            //WorkingWithTypes.TestExtensions();
            //WorkingWithTypes.TestIndexedProperties();
            //WorkingWithTypes.TypeConversion();

            //BoxingAndUnboxing.VerboseRun();
            KeydEnumerations.VerboseRun();

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
