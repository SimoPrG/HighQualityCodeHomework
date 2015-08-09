namespace School
{
    using System.Collections.Generic;
    using System.Linq;

    public class SchoolClass
    {
        private readonly IDictionary<int, Student> idStudentPairs;
        private int studentId;

        public SchoolClass()
        {
            this.idStudentPairs = new Dictionary<int, Student>();
            this.studentId = Constants.StudentIdMinValue;
        }

        public int RecordStudent(Student student)
        {
            // Check if the student is already recorded.
            var idStudentPairMaybe = this.idStudentPairs.FirstOrDefault(idStPair => idStPair.Value == student);
            bool isStudentAlreadyRecorded = idStudentPairMaybe.Equals(default(KeyValuePair<int, Student>)) == false;
            if (isStudentAlreadyRecorded)
            {
                return idStudentPairMaybe.Key;
            }

            bool areIdsUsedUp = this.studentId > Constants.StudentIdMaxValue;
            if (areIdsUsedUp)
            {
                throw new StudentIdException("All available student ids for this school are used-up");
            }

            var currentStudentId = this.studentId;
            this.idStudentPairs.Add(currentStudentId, student);

            this.studentId++;
            
            return currentStudentId;
        }

        public Student GetStudentById(int id)
        {
            return this.idStudentPairs.Where(idStPair => idStPair.Key == id).Select(idStPair => idStPair.Value).FirstOrDefault();
        }
    }
}
