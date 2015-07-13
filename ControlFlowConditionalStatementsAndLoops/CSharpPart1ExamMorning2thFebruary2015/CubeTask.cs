namespace CSharpPart1ExamMorning2thFebruary2015
{
    using System;

    public static class CubeTask
    {
        public static void Solve()
        {
            int n = int.Parse(Console.ReadLine());

            string topSpaceLine = new string(' ', n - 1);
            string topEdge = new string(':', n);
            Console.WriteLine("{0}{1}", topSpaceLine, topEdge);

            string topSideLine = new string('/', n - 2);
            string rightSideLine;
            for (int i = n - 3; i >= 0; i--)
            {
                topSpaceLine = new string(' ', i + 1);
                rightSideLine = new string('X', n - 3 - i);
                Console.WriteLine("{0}:{1}:{2}:", topSpaceLine, topSideLine, rightSideLine);                
            }
            
            string middleEdge = new string(':', n);
            rightSideLine = new string('X', n - 2);
            Console.WriteLine("{0}{1}:", middleEdge, rightSideLine);

            string frontSideLine = new string(' ', n - 2);
            for (int i = n - 3; i >= 0; i--)
            {
                rightSideLine = new string('X', i);
                Console.WriteLine(":{0}:{1}:", frontSideLine, rightSideLine);
            }

            string bottomEdge = new string(':', n);
            Console.WriteLine(bottomEdge);
        }
    }
}
