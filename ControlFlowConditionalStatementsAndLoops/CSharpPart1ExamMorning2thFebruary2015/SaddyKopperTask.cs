namespace CSharpPart1ExamMorning2thFebruary2015
{
    using System;
    using System.Numerics;

    public static class SaddyKopperTask
    {
        public static void Solve()
        {
            string publicsNumber = Console.ReadLine();
            long transformationsCount = 0;
            do
            {
                publicsNumber = Transform(publicsNumber);
                transformationsCount++;
            }
            while ((publicsNumber.Length > 1) && (transformationsCount < 10));

            if (transformationsCount == 10)
            {
                Console.WriteLine(BigInteger.Parse(publicsNumber));
            }
            else
            {
                Console.WriteLine(transformationsCount);
                Console.WriteLine(BigInteger.Parse(publicsNumber));
            }
        }

        private static string Transform(string publicsNumber)
        {
            BigInteger products = 1;
            for (int i = 0, length = publicsNumber.Length; i < length; i++)
            {
                publicsNumber = publicsNumber.Remove(publicsNumber.Length - 1);

                long sumAtEvenPositions = 0;
                for (int j = 0; j < publicsNumber.Length; j += 2)
                {
                    sumAtEvenPositions += publicsNumber[j] - '0';
                }

                if (publicsNumber != string.Empty)
                {
                    products *= sumAtEvenPositions;
                }
            }

            return products.ToString();
        }
    }
}
