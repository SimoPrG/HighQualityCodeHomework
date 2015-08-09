namespace School.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using School;

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void InitiallyStudentsCountShouldEqualZero()
        {
            var course = new Course();

            Assert.AreEqual(0, course.StudentsCount);
        }

        [TestMethod]
        public void AddingOneStudentShouldMakeStudentCountEqualToOne()
        {
            var student = new Student("Pesho");
            var course = new Course();

            course.AddStudent(student);

            Assert.AreEqual(1, course.StudentsCount);
        }

        [TestMethod]
        public void AddingOneStudentTwiceShouldMakeCourseHaveOnlyOneStudent()
        {
            var student = new Student("Pesho");
            var course = new Course();

            course.AddStudent(student);
            course.AddStudent(student);

            Assert.AreEqual(1, course.StudentsCount);
        }

        [TestMethod]
        public void RemovingSomeAddedStudentShouldReturnTrue()
        {
            var student = new Student("Pesho");
            var course = new Course();

            course.AddStudent(student);
            var isStudentRemoved = course.RemoveStudent(student);

            Assert.IsTrue(isStudentRemoved);
        }

        [TestMethod]
        public void RemovingNonAddedStudentShouldReturnFalse()
        {
            var student = new Student("Pesho");
            var course = new Course();

            var isStudentRemoved = course.RemoveStudent(student);

            Assert.IsFalse(isStudentRemoved);
        }

        [TestMethod]
        public void AddingAndRemovingAStudentShouldMakeStudentCountEqualToZero()
        {
            var student = new Student("Pesho");
            var course = new Course();

            course.AddStudent(student);
            course.RemoveStudent(student);

            Assert.AreEqual(0, course.StudentsCount);
        }

        [TestMethod]
        [ExpectedException(typeof(CourseCapacityException))]
        public void AddingMoreStudentsThanCapacityShouldThrowCourseCapacityException()
        {
            var course = new Course();
            for (int i = 1; i <= Constants.CourseCapacity + 1; i++)
            {
                var student = new Student("Pesho");
                course.AddStudent(student);
            }
        }
    }
}
