using System;

namespace CSharpPart1ExamMorning2thFebruary2015
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Task 1. Printing (Only in this task I exercised user input validation. For the rest you need to pass correct input.)");
            PrintingTask.Solve();

            Console.WriteLine("Task 2. Text to number");
            TextToNumberTask.Solve();

            Console.WriteLine("Task 3. Saddy Koper");
            SaddyKopperTask.Solve();

            Console.WriteLine("Task 4. Cube");
            CubeTask.Solve();

            Console.WriteLine("Task 5. Bits to Bits");
            BitsToBitsTask.Solve();
        }
    }
}
