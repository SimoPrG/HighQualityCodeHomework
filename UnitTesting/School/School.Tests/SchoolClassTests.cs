namespace School.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    using School;

    [TestClass]
    public class SchoolClassTests
    {
        [TestMethod]
        public void RecordedStudentsShouldHavveDifferentIds()
        {
            var student1 = new Student("Pesho");
            var student2 = new Student("Pesho");

            var school = new SchoolClass();
            int student1Id = school.RecordStudent(student1);
            int student2Id = school.RecordStudent(student2);

            Assert.AreNotEqual(student1Id, student2Id);
        }

        [TestMethod]
        public void RecordingStudentTwiceShouldReturnTheSameId()
        {
            var student = new Student("Pesho");
            var school = new SchoolClass();

            int idFromFirstRecording = school.RecordStudent(student);
            int idFromSecondRecording = school.RecordStudent(student);

            Assert.AreEqual(idFromFirstRecording, idFromSecondRecording);
        }

        [TestMethod]
        [ExpectedException(typeof(StudentIdException))]
        public void RecordingMoreStudentsThanAvailableIdsShouldThrowStudentIdException()
        {
            var school = new SchoolClass();
            for (int i = Constants.StudentIdMinValue; i <= Constants.StudentIdMaxValue + 1; i++)
            {
                var student = new Student("Pesho");
                school.RecordStudent(student);
            }
        }

        [TestMethod]
        public void GetStudentByIdShouldReturnTheStudentWithTheId()
        {
            var student1 = new Student("Pesho");
            var student2 = new Student("Pesho");

            var school = new SchoolClass();
            int student1Id = school.RecordStudent(student1);
            int student2Id = school.RecordStudent(student2);

            Assert.AreSame(student1, school.GetStudentById(student1Id), "The first student is not the same as the returned student with the first id");
            Assert.AreSame(student2, school.GetStudentById(student2Id), "The second student is not the same as the returned student with the second id");
        }

        [TestMethod]
        public void GetStudentByIdShouldReturnNullWhenStudentIdIsNotFound()
        {
            var school = new SchoolClass();
            var student = new Student("Pesho");

            var id = school.RecordStudent(student);
            var notExistingId = id + 1;

            Assert.IsNull(school.GetStudentById(notExistingId));
        }
    }
}
