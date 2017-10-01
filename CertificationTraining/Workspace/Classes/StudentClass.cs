namespace CertificationTraining.Workspace.Classes
{
    public class StudentClass
    {
        public static int StudentCount;

        public string FirstName;

        public string LastName;

        public int Grade;

        public StudentClass()
        {
        }

        public StudentClass(string firstName, string lastName, int grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string GetFullName()
        {
            return $"{LastName}, {FirstName}";
        }

        public string GetStudentDetails()
        {
            return $"{GetFullName()}; Grade {Grade}";
        }
    }
}
