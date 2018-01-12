using System;

namespace CertificationTraining.Workspace.Chapter2
{
    // The default value for AllowMultiple is true
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    class MyAttribute : Attribute
    {

    }

    [Serializable]
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    [My]
    //[My] // ERROR: My cannot be defined multiple times because AllowMultiple is set to false for this attribute's target (Default is true)
    class Dude
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        // ERROR: My cannot be defined for Method because My has the AttributeUsage defined only for the Class target
        //[My]
        public void Method()
        {

        }
    }

    class Attributes
    {
        public static void VerboseRun()
        {
            bool serialisableAttributeDefinedOnPerson = Attribute.IsDefined(typeof(Person), typeof(SerializableAttribute));
            bool serialisableAttributeDefinedOnDude = Attribute.IsDefined(typeof(Dude), typeof(SerializableAttribute));
            bool myAttributeDefinedOnPerson = Attribute.IsDefined(typeof(Person), typeof(MyAttribute));
            bool myAttributeDefinedOnDude = Attribute.IsDefined(typeof(Dude), typeof(MyAttribute));

            Console.WriteLine($"Does the '{nameof(Person)}' type have the '{nameof(SerializableAttribute)}' attribute? {serialisableAttributeDefinedOnPerson}");
            Console.WriteLine($"Does the '{nameof(Person)}' type have the '{nameof(MyAttribute)}' attribute? {myAttributeDefinedOnPerson}");

            Console.WriteLine($"Does the '{nameof(Dude)}' type have the '{nameof(SerializableAttribute)}' attribute? {serialisableAttributeDefinedOnDude}");
            Console.WriteLine($"Does the '{nameof(Dude)}' type have the '{nameof(MyAttribute)}' attribute? {myAttributeDefinedOnDude}");
        }
    }
}
