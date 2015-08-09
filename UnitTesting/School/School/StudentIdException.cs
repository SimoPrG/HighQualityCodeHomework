namespace School
{
    using System;

    public class StudentIdException : Exception
    {
        public StudentIdException(string message) : base(message)
        {
        }
    }
}
