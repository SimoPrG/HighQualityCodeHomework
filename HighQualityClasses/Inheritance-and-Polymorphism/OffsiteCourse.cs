namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    
    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string name, string teacherName, string town) :
            this(name, teacherName, town, new List<string>())
        {
        }

        public OffsiteCourse(string name, string teacherName, string town, ICollection<string> students) :
            base(name, teacherName, students)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            private set
            {
                Validator.ValidateName(value, "Town");
                this.town = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Town = " + this.Town + "; }";
        }
    }
}
