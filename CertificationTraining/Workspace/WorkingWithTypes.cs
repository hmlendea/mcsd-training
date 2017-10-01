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
            Book book = new Book("Hello World", "Greetings", "Program", 5, 2, "insertIsbnHere", "Fancy");

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
    }
}
