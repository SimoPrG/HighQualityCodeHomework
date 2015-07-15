using System;
using System.Linq;

public class MathProblem
{
    public static void Main()
    {
        const int NumBase = 19;

        string input = Console.ReadLine();
        string[] words = input.Split(' ');
        int sumIn10Base = SumWords(words, NumBase);
        string sumIn19Base = ConvertNumberToWord(sumIn10Base, NumBase);
        Console.WriteLine("{0} = {1}", sumIn19Base, sumIn10Base);
    }

    private static int SumWords(string[] words, int numBase)
    {
        return words.Sum(w => ConvertWordToNumber(w.ToLower(), numBase));
    }

    private static int ConvertWordToNumber(string word, int numBase)
    {
        int number = 0;
        for (int i = 0; i < word.Length; i++)
        {
            int digit = word[word.Length - 1 - i] - 'a';
            number += digit * (int)Math.Pow(numBase, i);
        }

        return number;
    }

    private static string ConvertNumberToWord(int number, int numBase)
    {
        string word = string.Empty;
        if (number == 0)
        {
            word = "a";
        }

        while (number > 0)
        {
            char letter = (char)((number % numBase) + 'a');
            word = letter + word;
            number /= numBase;
        }

        return word;
    }
}