namespace School
{
    using System.Collections.Generic;

    public class Course
    {
        private readonly ICollection<Student> students;

        public Course()
        {
            this.students = new HashSet<Student>();
        }

        public int StudentsCount
        {
            get { return this.students.Count; }
        }

        public void AddStudent(Student student)
        {
            if (this.StudentsCount == Constants.CourseCapacity)
            {
                throw new CourseCapacityException("Course capacity is reached");
            }

            this.students.Add(student);
        }

        public bool RemoveStudent(Student student)
        {
            return this.students.Remove(student);
        }
    }
}
