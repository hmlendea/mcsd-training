using System;
using System.Linq;
using System.Reflection;

namespace CertificationTraining.Workspace.Chapter2
{
    interface IMyInterface
    {
        int Value { get; set; }
    }

    class ImplementedClass1 : IMyInterface
    {
        public int Value { get; set; }
        private int PrivateValue { get; set; }
    }
    class ImplementedClass2 : IMyInterface
    {
        public int Value
        {
            get
            {
                return PrivateValue;
            }
            set
            {
                PrivateValue = value;
            }
        }
        private int PrivateValue;
    }
    class ImplementedClass3 : IMyInterface
    {
        public int Value { get; set; }
        private int PrivateValue;
        int a; // Compiler will keep this unused field
    }

    class Reflection
    {
        int degeaba; // Compiler will keep this unused field

        public static void VerboseRun()
        {
            int nr = 873;
            int blabla; // Compiler will not keep this unused field

            Console.WriteLine($"int {nameof(nr)} = {873};");
            Console.WriteLine($"{nameof(nr)}.GetType() = {nr.GetType()}");

            // Load the assembly. It only loads it once, even if you call it multiple times.
            Assembly assembly = Assembly.Load("CertificationTraining");

            // Get the types that our interface can be assigned from
            var implementedClasses = assembly
                .GetTypes()
                .Where(type => typeof(IMyInterface).IsAssignableFrom(type));

            Console.Write($"The '{nameof(IMyInterface)}' interface is assignable from: ");
            foreach (Type type in implementedClasses)
            {
                string typeName = type.Name;

                Console.Write($"'{typeName}', ");
            }
            Console.WriteLine();

            ImplementedClass1 class1 = new ImplementedClass1();
            ImplementedClass2 class2 = new ImplementedClass2();
            ImplementedClass3 class3 = new ImplementedClass3();

            DumpObject(class1);
            DumpObject(class2);
            DumpObject(class3);
        }

        static void DumpObject(object obj)
        {
            Type objType = obj.GetType();
            FieldInfo[] fields = objType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty);
            
            Console.Write($"All the private integer fields of '{objType.Name}': ");

            foreach (FieldInfo field in fields)
            {
                {
                    Console.Write($"{field.Name}, ");
                }
            }

            Console.WriteLine();
        }
    }
}
