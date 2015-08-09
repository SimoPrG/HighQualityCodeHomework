namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using School;
    
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void CreatingStudentWithNameShouldHaveProperName()
        {
            var name = "Pesho";
            var student = new Student(name);
            Assert.AreEqual(name, student.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreatingStudentWithEmptyNameShouldThrowArgumentException()
        {
            new Student("");
        }
    }
}
