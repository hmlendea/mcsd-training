namespace CertificationTraining.Workspace
{
    public struct Student
    {
        public string firstName;
        public string lastName;
        public double score1;

        public Student(string first, string last)
        {
            this.firstName = first;
            this.lastName = last;

            this.score1 = 1; // all fields must be initialised *in the constructor*

            AssignScore1(); // it can only be called once all the fields are assigned
        }

        public void AssignScore1()
        {
            this.score1 = 2;
        }
    }
}
