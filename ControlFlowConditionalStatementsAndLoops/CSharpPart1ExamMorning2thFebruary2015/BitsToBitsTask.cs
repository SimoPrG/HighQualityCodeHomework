namespace CSharpPart1ExamMorning2thFebruary2015
{
    using System;

    public static class BitsToBitsTask
    {
        public static void Solve()
        {
            int numbersCount = int.Parse(Console.ReadLine());

            string concatenatedBitsSequence = null;
            for (int i = 0; i < numbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                string binaryRepresentation = Convert.ToString(currentNumber, 2).PadLeft(32, '0');
                string mostRight30Bits = binaryRepresentation.Remove(0, 2);
                concatenatedBitsSequence += mostRight30Bits;
            }

            int longestSequenceOfZeroes = GetLongestSymbolSequenceLength('0', concatenatedBitsSequence);
            Console.WriteLine(longestSequenceOfZeroes);

            int longestSequenceOfOnes = GetLongestSymbolSequenceLength('1', concatenatedBitsSequence);
            Console.WriteLine(longestSequenceOfOnes);
        }

        private static int GetLongestSymbolSequenceLength(char symbol, string text)
        {
            int currentSequenceLength = 0;
            int longestSequenceLength = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == symbol)
                {
                    currentSequenceLength++;
                }
                else
                {
                    currentSequenceLength = 0;
                }

                if (currentSequenceLength > longestSequenceLength)
                {
                    longestSequenceLength = currentSequenceLength;
                }
            }

            return longestSequenceLength;
        }
    }
}
