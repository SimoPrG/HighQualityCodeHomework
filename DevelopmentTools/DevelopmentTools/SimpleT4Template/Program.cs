namespace SimpleT4Template
{
    using System;

    class Program
    {
        static void Main()
        {
            var namesBundle = new NamesBundle();
            namesBundle.Name1 = "Simeon";
            namesBundle.Name25 = "Pesho";
            namesBundle.Name50 = "Stamat";

            foreach (var name in namesBundle.GetProperties())
            {
                Console.WriteLine(name);
            }
        }
    }
}