using System;

using CertificationTraining.Workspace.Classes;
using CertificationTraining.Workspace.Extensions;
using CertificationTraining.Workspace.Structs;

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

        public static void UsingValueTypes()
        {
            int myInt = 5000;
            Console.WriteLine("Integer");
            Console.WriteLine($" > type = {myInt.GetType()}");
            Console.WriteLine($" > value = {myInt}");
            Console.WriteLine($" > range = [{int.MinValue}, {int.MaxValue}]");
            Console.WriteLine($" > size = {sizeof(int)} bytes");
            Console.WriteLine();

            double myDouble = 5000.0;
            Console.WriteLine("Double");
            Console.WriteLine($" > type = {myDouble.GetType()}");
            Console.WriteLine($" > value = {myDouble}");
            Console.WriteLine($" > range = {double.MinValue}, {double.MaxValue}]");
            Console.WriteLine($" > size = {sizeof(double)} bytes");
            Console.WriteLine();

            byte myByte = 254;
            Console.WriteLine("Byte");
            Console.WriteLine($" > type = {myByte.GetType()}");
            Console.WriteLine($" > value = {myByte}");
            Console.WriteLine($" > range = [{byte.MinValue}, {byte.MaxValue}]");
            Console.WriteLine($" > size = {sizeof(byte)} bytes");
            Console.WriteLine();

            char myChar = 'r';
            Console.WriteLine("Char");
            Console.WriteLine($" > type = {myChar.GetType()}");
            Console.WriteLine($" > value = {myChar}");
            Console.WriteLine($" > range = ['{char.MinValue}'({(int)char.MinValue}), '{char.MaxValue}'({(int)char.MaxValue})]");
            Console.WriteLine($" > size = {sizeof(char)} bytes");
            Console.WriteLine();

            decimal myDecimal = 20987.89756M;
            Console.WriteLine("Decimal");
            Console.WriteLine($" > type = {myDecimal.GetType()}");
            Console.WriteLine($" > value = {myDecimal}");
            Console.WriteLine($" > range = [{decimal.MinValue}, {decimal.MaxValue}]");
            Console.WriteLine($" > size = {sizeof(decimal)} bytes");
            Console.WriteLine();

            float myFloat = 254.09F;
            Console.WriteLine("Float");
            Console.WriteLine($" > type = {myFloat.GetType()}");
            Console.WriteLine($" > value = {myFloat}");
            Console.WriteLine($" > range = [{float.MinValue}, {float.MaxValue}]");
            Console.WriteLine($" > size = {sizeof(float)} bytes");
            Console.WriteLine();

            long myLong = 2544567538754;
            Console.WriteLine("Long");
            Console.WriteLine($" > value = {myLong}");
            Console.WriteLine($" > type = {myLong.GetType()}");
            Console.WriteLine($" > range = [{long.MinValue}, {long.MaxValue}]");
            Console.WriteLine($" > size = {sizeof(long)} bytes");
            Console.WriteLine();

            short myShort = 3276;
            Console.WriteLine("Short");
            Console.WriteLine($" > value = {myShort}");
            Console.WriteLine($" > type = {myShort.GetType()}");
            Console.WriteLine($" > range = [{short.MinValue}, {short.MaxValue}]");
            Console.WriteLine($" > size = {sizeof(short)} bytes");
            Console.WriteLine();

            bool myBool = true;
            Console.WriteLine("Boolean");
            Console.WriteLine($" > value = {myBool}");
            Console.WriteLine($" > type = {myBool.GetType()}");
            Console.WriteLine($" > range = {{{false}, {true}}}");
            Console.WriteLine($" > size = {sizeof(bool)} bytes");
            Console.WriteLine();
        }

        public static void TestBookStruct()
        {
            BookStruct book = new BookStruct("Hello World", "Greetings", "Program", 5, 2, "insertIsbnHere", "Fancy");

            Console.WriteLine($"book.Title = {book.Title}");
            Console.WriteLine($"book.Category = {book.Category}");
            Console.WriteLine($"book.Author = {book.Author}");
            Console.WriteLine($"book.PageCount = {book.PageCount}");
            Console.WriteLine($"book.Page = {book.Page}");
            Console.WriteLine($"book.ISBN = {book.ISBN}");
            Console.WriteLine($"book.CoverStyle = {book.CoverStyle}");
            Console.WriteLine();

            Console.WriteLine("book.NextPage();");
            book.NextPage();
            Console.WriteLine($"book.Page = {book.Page}");
            Console.WriteLine();

            Console.WriteLine("book.PreviousPage();");
            book.PreviousPage();
            Console.WriteLine($"book.Page = {book.Page}");
            Console.WriteLine();

            Console.WriteLine("book.NextPage(); x10 times");
            for (int i = 0; i < 10; i++)
            {
                book.NextPage();
            }
            Console.WriteLine($"book.Page = {book.Page}");
            Console.WriteLine();
        }

        public static void TestStudentClass()
        {
            StudentClass student1 = new StudentClass();
            StudentClass.StudentCount += 1;

            student1.firstName = "Jon";
            student1.lastName = "Snow";
            student1.schoolName = "Night's Watch";
            student1.grade = 4; // knows nothing

            // SAMPLE: Class constructor
            StudentClass student2 = new StudentClass("Tyrion", "Lannister", "Școala vieții", 10);
            StudentClass.StudentCount += 1;

            // SAMPLE: Method overloading
            StudentClass student3 = new StudentClass("New", "Student", "School");
            StudentClass.StudentCount += 1;

            // SAMPLE: Named parameters
            StudentClass student4 = new StudentClass(lastName: "Last", schoolName: "School", firstName: "First");

            // SAMPLE: Static fields
            // Wont' work. static variables are contained by the class itself not by its instances
            // student4.StudentCount += 1;
            // This will work fine as the field belongs to the class itself
            StudentClass.StudentCount += 1;

            Console.WriteLine($"student1.FirstName = {student1.firstName}");
            Console.WriteLine($"student2.FirstName = {student2.firstName}");
            Console.WriteLine($"student3.SchoolName = {student3.schoolName}");
            Console.WriteLine($"StudentClass.StudentCount = {StudentClass.StudentCount}");
            Console.WriteLine();

            // SAMPLE: Class methods - call
            Console.WriteLine($"student2.GetStudentDetails() = \"{student2.GetStudentDetails()}\"");
        }

        public static void TestExtensions()
        {
            int a = 2;
            int b = a.GetSquare();

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"a.GetSquare() = {b}");
        }

        public static void TestIndexedProperties()
        {
            IPAddress myIP = new IPAddress();

            for (int i = 0; i < 32; i++)
            {
                myIP[i] = 0;
            }
        }

        public static void BoxingAndUnboxing()
        {
            // SAMPLE: Boxing and unboxing

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

        public static void TypeConversion()
        {
            // SAMPLE: Type conversion - implicit
            StudentStruct studentStruct = new StudentStruct("Gandalf", "Grey");
            StudentClass studentClass = studentStruct;

            Console.WriteLine("StudentStruct studentStruct = new StudentStruct(\"Gandalf\", \"Grey\");");
            Console.WriteLine("StudentClass studentClass = studentStruct;");
            Console.WriteLine($"studentClass.GetStudentDetails() = {studentClass.GetStudentDetails()}");
        }
    }
}
