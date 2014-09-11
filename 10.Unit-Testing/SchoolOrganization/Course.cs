namespace SchoolOrganization
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MaxNumberOfStudentsInCourse = 29;

        private string name;
        private ICollection<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Course name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null!");
            }

            if (this.students.Count >= MaxNumberOfStudentsInCourse)
            {
                throw new ArgumentOutOfRangeException("Student cannot be added! Students in course cannot be more than " + MaxNumberOfStudentsInCourse);
            }

            this.students.Add(student);
        }

        public void RemoveStudent(int fn)
        {
            if (fn < 1)
            {
                throw new ArgumentOutOfRangeException("Faculty number of student cannot be less than 1!");
            }

            if (this.students.Count == 0)
            {
                throw new ArgumentNullException("Cannot remove student! Students list is empty!");
            }

            foreach (var student in this.students)
            {
                if (student.FN == fn)
                {
                    this.students.Remove(student);
                    break;
                }
            }

            throw new ArgumentException("Invalid Faculty number! There is no student with such FN.");
        }
    }
}
