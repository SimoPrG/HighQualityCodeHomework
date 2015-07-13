namespace ChefInCSharp
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Testing task 1 and task 2 - first part:");
            TestTask1AndTask2FirstPart();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);

            Console.WriteLine("\nTesting task 2 - second part:");
            TestTask2SecondPart();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);

            Console.WriteLine("\nTesting task 3:");
            TestTask3();
        }

        private static void TestTask1AndTask2FirstPart()
        {
            var vegetableFactory = new VegetableFactory();
            var potato = vegetableFactory.GetVegetable(VegetableType.Potato);
            var chef = new Chef();
            var preCookedPotato = chef.PreCook(potato);

            if (preCookedPotato == null)
            {
                throw new Exception("potato cannot be null");
            }

            if (preCookedPotato.IsPeeled && !preCookedPotato.IsRotten)
            {
                chef.Cook(potato);
            }
        }

        private static void TestTask2SecondPart()
        {
            const int MIN_X = 0;
            const int MAX_X = 9;
            const int MIN_Y = 0;
            const int MAX_Y = 9;

            int x = 5;
            int y = 5;

            bool isInRange = (MIN_X <= x) && (x <= MAX_X) && (MIN_Y <= y) && (y <= MAX_Y);

            bool canVisitCell = true;

            if (isInRange && canVisitCell)
            {
                VisitCell();
            }
        }

        private static void TestTask3()
        {
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            int expectedValue = 50;
            bool isValueFound = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        isValueFound = true;
                    }
                }

                Console.WriteLine(array[i]);
            }

            if (isValueFound)
            {
                Console.WriteLine("Value Found");
            }
        }

        private static void VisitCell()
        {
            Console.WriteLine("Visiting the cell...");
        }
    }
}
