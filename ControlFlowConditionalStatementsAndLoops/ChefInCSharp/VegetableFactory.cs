namespace ChefInCSharp
{
    using System;

    class VegetableFactory
    {
        public Vegetable GetVegetable(VegetableType type)
        {
            Vegetable vegetable;
            switch (type)
            {
                case VegetableType.Carrot:
                    vegetable = new Carrot();
                    break;
                case VegetableType.Potato:
                    vegetable = new Potato();
                    break;
                default:
                    throw new ArgumentException(string.Format("Cannot create vegetable of type {0}", type));
            }

            Console.WriteLine("Getting a {0}...", vegetable.Name);

            return vegetable;
        }
    }
}
