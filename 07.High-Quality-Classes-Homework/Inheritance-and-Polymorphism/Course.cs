using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class Course
    {
        public string Name { get; set; }
        public string TeacherName { get; set; }
        public IList<string> Students { get; set; }

        public Course(string name)
        {
            this.Name = name;
            this.Students = new List<string>();
        }

        public Course(string courseName, string teacherName) :this(courseName)
        {
            this.TeacherName = teacherName;
        }

        public Course(string courseName, string teacherName, IList<string> students) : this(courseName, teacherName)
        {
            this.Students = students;
        }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.GetType().Name);
            result.Append(" { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
           
            return result.ToString();
        }
    }
}
