namespace SchoolOrganization
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int fn;

        public Student(string firstName, string lastName, int fn)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name of student cannot be null or emrty!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name of student cannot be null or emrty!");
                }

                this.lastName = value;
            }
        }

        public int FN {
            get { return this.fn; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Faculty number cannot be less than 1.");
                }

                this.fn = value;
            }
        }
    }
}
