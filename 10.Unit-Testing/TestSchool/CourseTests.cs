using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolOrganization;

namespace TestSchool
{
    [TestClass]
    public class CourseTests
    {
        private Course course;

        [TestInitialize]
        public void InitializeCourse()
        {
            this.course = new Course("High Quality Code");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldHaveNameWhenInitialized()
        {
            Course courseWithoutName = new Course("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullStudentShouldNotBeAdded()
        {
            course.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExceedMaximumNumberOfStudents()
        {
            for (int i = 0; i < 30; i++)
            {
                course.AddStudent(new Student("Ime", "Ime", (20000 + i)));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldNotRemoveStudentByInvalidFN()
        {
            course.AddStudent(new Student("Ivan", "Ivanov", 12345));
            course.RemoveStudent(54321);   
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldNotRemoveStudentWithFNLowerThan1()
        {
            course.AddStudent(new Student("Ivan", "Ivanov", -12345));
            course.RemoveStudent(54321);  
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldNotRemoveStudentOfEmptyList()
        {
            course.RemoveStudent(54321);  
        }
    }
}
