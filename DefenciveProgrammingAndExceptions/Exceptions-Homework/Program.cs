namespace Exceptions
{
    using System;
    using System.Collections.Generic;

    using Exceptions.Utils;

    public static class Program
    {
        public static void Main()
        {
            var substr = ArrayUtils.GetSubsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = ArrayUtils.GetSubsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(string.Join(" ", subarr));

            var allarr = ArrayUtils.GetSubsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(string.Join(" ", allarr));

            var emptyarr = ArrayUtils.GetSubsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(string.Join(" ", emptyarr));

            Console.WriteLine(StringUtils.ExtractEnding("I love C#", 2));
            Console.WriteLine(StringUtils.ExtractEnding("Nakov", 4));
            Console.WriteLine(StringUtils.ExtractEnding("beer", 4));
            // Console.WriteLine(StringUtils.ExtractEnding("Hi", 100));
            
            WriteIsPrime(23);
            WriteIsPrime(33);

            List<IExam> peterExams = new List<IExam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }

        private static void WriteIsPrime(int number)
        {
            bool isPrime = MathUtils.IsPrime(number);
            if (isPrime)
            {
                Console.WriteLine(number + " is prime.");
            }
            else
            {
                Console.WriteLine(number + " is not prime.");
            }
        }
    }
}