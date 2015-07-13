namespace CSharpPart1ExamMorning2thFebruary2015
{
    using System;
    using System.Numerics;

    public static class TextToNumberTask
    {
        public static void Solve()
        {
            BigInteger divisor = BigInteger.Parse(Console.ReadLine());
            string text = Console.ReadLine().ToUpper();

            BigInteger result = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '@')
                {
                    break;
                }
                else if (char.IsDigit(text[i]))
                {
                    int multiplier = text[i] - '0';
                    result *= multiplier;
                }
                else if (char.IsLetter(text[i]))
                {
                    int addend = text[i] - 'A';
                    result += addend;
                }
                else
                {
                    result %= divisor;
                }
            }

            Console.WriteLine(result);
        }
    }
}
