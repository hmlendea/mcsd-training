using System;

namespace CertificationTraining.Workspace.Classes
{
    public class StudentClass
    {
        public static int StudentCount;

        public string firstName;

        public string lastName;

        public string schoolName;

        public int grade;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string SchoolName
        {
            get
            {
                return schoolName;
            }
            set
            {
                schoolName = value;
            }
        }

        public int Grade
        {
            get
            {
                return grade;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException($"Invalid value for '{nameof(Grade)}'");
                }

                grade = value;
            }
        }

        public StudentClass()
        {
        }

        public StudentClass(string firstName, string lastName, string schoolName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.schoolName = schoolName;
            grade = -1;
        }

        public StudentClass(string firstName, string lastName, string schoolName, int grade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.schoolName = schoolName;
            this.grade = grade;
        }

        // SAMPLE: Class methods - implementation
        public string GetStudentDetails()
        {
            return $"Name={GetFullName()}; School={schoolName}; Grade={grade}";
        }

        // SAMPLE: Class methods - calling a method from withing a method
        private string GetFullName()
        {
            return $"{lastName}, {firstName}";
        }
    }
}
