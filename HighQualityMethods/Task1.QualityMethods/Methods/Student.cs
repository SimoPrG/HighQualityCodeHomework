namespace Methods
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;

        public Student(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, string otherInfo) :
            this(firstName, lastName, dateOfBirth)
        {
            this.OtherInfo = otherInfo;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("FirstName cannot be null or white space");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("LastName cannot be null or white space");
                }

                this.lastName = value;
            }
        }

        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }

        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            return this.DateOfBirth < other.DateOfBirth;
        }
    }
}
