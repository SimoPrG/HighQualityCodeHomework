namespace Statistics
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Provides static methods to print collection statistics.
    /// </summary>
    public static class Printer
    {
        /// <summary>
        /// Prints the minimum value found in the <paramref name="values"/> up to <paramref name="position"/> on the console.
        /// </summary>
        /// <param name="values">The collection of values.</param>
        /// <param name="position">The position to which to look for the minimum value.</param>
        public static void PrintMin(IList<double> values, int position)
        {
            double minValue = values[0];
            for (int i = 1; i < position; i++)
            {
                if (values[i] < minValue)
                {
                    minValue = values[i];
                }
            }

            Console.WriteLine(minValue);
        }

        /// <summary>
        /// Prints the maximum value found in the <paramref name="values"/> up to <paramref name="position"/> on the console.
        /// </summary>
        /// <param name="values">The collection of values.</param>
        /// <param name="position">The position to which to look for the maximum value.</param>
        public static void PrintMax(IList<double> values, int position)
        {
            double maxValue = values[0];
            for (int i = 1; i < position; i++)
            {
                if (maxValue < values[i])
                {
                    maxValue = values[i];
                }
            }

            Console.WriteLine(maxValue);
        }

        /// <summary>
        /// Prints the average value of the <paramref name="values"/> up to <paramref name="position"/> on the console.
        /// </summary>
        /// <param name="values">The collection of values.</param>
        /// <param name="position">The position to which to calculate the average value.</param>
        public static void PrintAverage(IList<double> values, int position)
        {
            double sum = 0;
            for (int i = 0; i < position; i++)
            {
                sum += values[i];
            }

            double average = sum / position;
            Console.WriteLine(average);
        }

        /// <summary>
        /// Prints the statistics of <paramref name="values"/> up to <paramref name="position"/> on the console.
        /// </summary>
        /// <param name="values">The collection of values.</param>
        /// <param name="position">The position to which to calculate the statistics.</param>
        public static void PrintStatistics(IList<double> values, int position)
        {
            PrintMax(values, position);

            PrintMin(values, position);

            PrintAverage(values, position);
        }
    }
}
