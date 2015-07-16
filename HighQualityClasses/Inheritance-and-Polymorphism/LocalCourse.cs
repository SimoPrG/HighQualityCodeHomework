namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;

    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string name, string teacherName, string lab) :
            this(name, teacherName, lab, new List<string>())
        {
        }

        public LocalCourse(string name, string teacherName, string lab, ICollection<string> students) :
            base(name, teacherName, students)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }

            private set
            {
                Validator.ValidateName(value, "Lab");
                this.lab = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Lab = " + this.Lab + "; }";
        }
    }
}
