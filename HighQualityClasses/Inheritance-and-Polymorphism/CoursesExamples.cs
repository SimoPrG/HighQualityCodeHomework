namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    
    public class CoursesExamples
    {
        public static void Main()
        {
            var localCourse = new LocalCourse(
                "Databases",
                "Svetlin Nakov",
                "Enterprise");

            Console.WriteLine(localCourse);

            localCourse.AddStudents("Milena", "Todor");
            localCourse.AddStudents(new List<string>() { "Peter", "Maria" });

            Console.WriteLine(localCourse);

            var offsiteCourse = new OffsiteCourse(
                "PHP and WordPress Development",
                "Mario Peshev",
                "San Francisco",
                new List<string>() { "Thomas", "Ani", "Steve" });

            Console.WriteLine(offsiteCourse);

            offsiteCourse.AddStudents(new[] { "Jane", "Marry" });

            Console.WriteLine(offsiteCourse);
        }
    }
}
