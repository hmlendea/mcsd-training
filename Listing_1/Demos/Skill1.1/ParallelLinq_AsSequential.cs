using System;
using System.Linq;
using System.Threading;

namespace CertifV2.Demos
{
    class ParallelLinq_AsSequential
    {
        class Person
        {
            static Random random = new Random();

            public string Name { get; set; }

            public string NameWithDelay
            {
                get
                {
                    Console.WriteLine("Getting " + Name);
                    Thread.Sleep(random.Next(0, 1000));
                    return Name;
                }
            }

            public string City { get; set; }
        }

        public static void Start()
        {
            Person[] people = new Person[] {
                new Person { Name = "Alan", City = "Hull" },
                new Person { Name = "Beryl", City = "Seattle" },
                new Person { Name = "Jeff", City = "Seattle" },
                new Person { Name = "Charles", City = "London" },
                new Person { Name = "David", City = "Seattle" },
                new Person { Name = "Eddy", City = "Paris" },
                new Person { Name = "Fred", City = "Berlin" },
                new Person { Name = "Gordon", City = "Hull" },
                new Person { Name = "Henry", City = "Seattle" },
                new Person { Name = "Isaac", City = "Seattle" },
                new Person { Name = "Bobbert", City = "Seattle" },
                new Person { Name = "Bozzart", City = "Seattle" },
                new Person { Name = "James", City = "London" }};

            var result = (from person in people.AsParallel()
                          where person.City == "Seattle"
                          orderby (person.NameWithDelay)
                          select new
                          {
                              Name = person.Name
                          }).Take(4);

            foreach (var person in result)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
