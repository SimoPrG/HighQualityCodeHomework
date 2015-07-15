using System;

public class SumOfDifferences
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string[] numbersAsString = input.Split(' ');
        long[] numbers = new long[numbersAsString.Length];
        for (int i = 0; i < numbersAsString.Length; i++)
        {
            numbers[i] = long.Parse(numbersAsString[i]);
        }

        long answer = SumDifferences(numbers);
        Console.WriteLine(answer);
    }

    private static long SumDifferences(long[] numbers)
    {
        long sum = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            long difference = Math.Abs(numbers[i] - numbers[i - 1]);
            if (difference % 2 == 0)
            {
                i++;
            }
            else
            {
                sum += difference;
            }
        }

        return sum;
    }
}
