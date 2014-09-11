using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolOrganization;

namespace TestSchool
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]    
        public void FirstNameShouldNotBeNull()
        {
            Student student = new Student("", "Kirov", 12345);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]    
        public void LastNameShouldNotBeNull()
        {
            Student student = new Student("Kiro", "", 12345);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]    
        public void FacultyNumberShouldBeCorrectlyInitialized()
        {
            Student student = new Student("Kiro", "Kirov", -1);
        }
    }
}
