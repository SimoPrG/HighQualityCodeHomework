namespace CSharpPart1ExamMorning2thFebruary2015
{
    using System;
    using System.ComponentModel;

    public static class PrintingTask
    {
        public static void Solve()
        {
            long numberOfStudents = GetValueFromUser<long>("number of students");
            long sheetsPerStudent = GetValueFromUser<long>("number of sheets per student");
            decimal realmsNeeded = (decimal)(numberOfStudents * sheetsPerStudent) / 500;

            decimal realmPrice = GetValueFromUser<decimal>("realm price");
            decimal totalPrice = realmsNeeded * realmPrice;

            Console.WriteLine("{0:F2}", totalPrice);
        }

        private static T GetValueFromUser<T>(string valueName) where T : IComparable<T>
        {
            T value = default(T);
            bool isValueValid = false;

            do
            {
                Console.Write("please, enter a " + valueName + ": ");
                string input = Console.ReadLine();
                try
                {
                    TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
                    value = (T)converter.ConvertFromString(input);

                    if (value.CompareTo(default(T)) >= 0)
                    {
                        isValueValid = true;
                    }
                    else
                    {
                        Console.WriteLine(valueName + " cannot be negative!");
                    }
                }
                catch
                {
                    Console.WriteLine("you made a typo. try again!");
                }
            }
            while (!isValueValid);

            return value;
        }
    }
}
