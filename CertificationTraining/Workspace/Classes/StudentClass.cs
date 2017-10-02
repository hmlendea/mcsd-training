namespace CertificationTraining.Workspace.Classes
{
    public class StudentClass
    {
        public static int StudentCount;

        public string FirstName;

        public string LastName;

        public string SchoolName;

        public int Grade;

        public StudentClass()
        {
        }

        public StudentClass(string firstName, string lastName, string schoolName)
        {
            FirstName = firstName;
            LastName = lastName;
            SchoolName = schoolName;
            Grade = -1;
        }

        public StudentClass(string firstName, string lastName, string schoolName, int grade)
        {
            FirstName = firstName;
            LastName = lastName;
            SchoolName = schoolName;
            Grade = grade;
        }

        // SAMPLE: Class methods - implementation
        public string GetStudentDetails()
        {
            return $"Name={GetFullName()}; School={SchoolName}; Grade={Grade}";
        }

        // SAMPLE: Class methods - calling a method from withing a method
        private string GetFullName()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}
