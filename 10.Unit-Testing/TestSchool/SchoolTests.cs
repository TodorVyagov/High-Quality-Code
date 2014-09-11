namespace TestSchool
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolOrganization;

    [TestClass]
    public class SchoolTests
    {
        // I do not have ULTIMATE version of Visual Studio and cannot see what percent of code coverage do I have, so I made the required tests.
        private School school;

        [TestInitialize]
        public void InitializeSchool()
        {
            this.school = new School("Telerik Academy");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldHaveNameWhenInitialized()
        {
            School school = new School(" ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FacultyNumberShouldBeGreaterThan9999()
        {
            school.AddStudent("Kiro", "Kirov", 1000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FacultyNumberShouldBeLessThan100000()
        {
            school.AddStudent("Kiro", "Kirov", 100000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FacultyNumberShouldBeUnique()
        {
            school.AddStudent("Kiro", "Kirov", 12345);
            school.AddStudent("Ivan", "Ivanov", 12345);
        }
    }
}
