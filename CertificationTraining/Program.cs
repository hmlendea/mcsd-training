using System;

using CertificationTraining.Workspace.Chapter2;
using CertificationTraining.Workspace.Others;

namespace CertificationTraining
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** MCSD Training samples and tests ***");
            Console.WriteLine();

            //// CHAPTER 2
            //WorkingWithTypes.CompareValueTypesAndTheirAliases();
            //WorkingWithTypes.UsingValueTypes();
            //WorkingWithTypes.TestBookStruct();
            //WorkingWithTypes.TestStudentClass();
            //WorkingWithTypes.TestExtensions();
            //WorkingWithTypes.TestIndexedProperties();
            //WorkingWithTypes.TypeConversion();

            //BoxingAndUnboxing.VerboseRun();
            //KeydEnumerations.VerboseRun();
            //Attributes.VerboseRun();
            Reflection.VerboseRun();

            //// OTHERS
            //FormatedLoggerTests.VerboseRun();

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
