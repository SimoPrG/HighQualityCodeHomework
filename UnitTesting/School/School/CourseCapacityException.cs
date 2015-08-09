namespace School
{
    using System;

    public class CourseCapacityException : Exception
    {
        public CourseCapacityException(string message) : base(message)
        {
        }
    }
}
