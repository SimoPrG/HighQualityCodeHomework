namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Course
    {
        private string name;
        private string teacherName;
        private ICollection<string> students;

        protected Course(string name, string teacherName, ICollection<string> students)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.ValidateName(value, "Name");
                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            private set
            {
                Validator.ValidateName(value, "TeacherName");
                this.teacherName = value;
            }
        }

        public ICollection<string> Students
        {
            get
            {
                // Return copy of the list.
                return this.students.ToList();
            }

            private set
            {
                Validator.ValidateObjectIsNotNull(value, "Students");
                this.students = value.ToList();
            }
        }

        public void AddStudents(params string[] newStudents)
        {
            foreach (var newStudent in newStudents)
            {
                Validator.ValidateName(newStudent, "newStudent");
            }

            foreach (var newStudent in newStudents)
            {
                this.students.Add(newStudent);
            }
        }

        public void AddStudents(IEnumerable<string> newStudents)
        {
            foreach (var newStudent in newStudents)
            {
                Validator.ValidateName(newStudent, "newStudent");
            }

            foreach (var newStudent in newStudents)
            {
                this.students.Add(newStudent);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(
                this.GetType().Name +
                " { Name = " + this.Name +
                "; Teacher = " + this.TeacherName +
                "; Students = " + this.GetStudentsAsString() +
                "; ");

            return result.ToString();
        }

        private string GetStudentsAsString()
        {
            var result = new StringBuilder();

            result.Append("{ ");
            result.Append(string.Join(", ", this.Students));
            result.Append(this.Students.Count > 0 ? " }" : "}");

            return result.ToString();
        }
    }
}
