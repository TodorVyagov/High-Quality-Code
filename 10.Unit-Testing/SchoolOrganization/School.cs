namespace SchoolOrganization
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private const int MinStudentNumber = 10000;
        private const int MaxStudentNumber = 99999;

        private string name;
        private ICollection<Student> students;

        public School(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("School name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public void AddStudent(string firstName, string lastName, int fn)
        {
            if (fn < MinStudentNumber || fn > MaxStudentNumber)
            {
                throw new ArgumentOutOfRangeException(string.Format("Faculty number must be between {0} and {1}.", MinStudentNumber, MaxStudentNumber));
            }

            if (this.students.Count != 0)
            {
                foreach (var student in this.students)
                {
                    if (student.FN == fn)
                    {
                        throw new ArgumentException("The faculty number must be unique! Try with new fn.");
                    }
                }
            }

            Student studentToAdd = new Student(firstName, lastName, fn);
            students.Add(studentToAdd);
        }
    }
}
