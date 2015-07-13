namespace ChefInCSharp
{
    using System;

    public class Chef
    {
        public void Cook(Vegetable vegetable)
        {
            Bowl bowl = new Bowl();
            bowl.Add(vegetable);
        }

        public Vegetable PreCook(Vegetable vegetable)
        {
            if (vegetable.IsRotten)
            {
                return null;
            }

            Vegetable peeledVegetable = this.Peel(vegetable);
            Vegetable cuttedVegetable = this.Cut(peeledVegetable);

            return cuttedVegetable;
        }

        private Vegetable Peel(Vegetable vegetable)
        {
            Console.WriteLine("Peeling the {0}...", vegetable.Name);
            vegetable.IsPeeled = true;
            return vegetable;
        }

        private Vegetable Cut(Vegetable vegetable)
        {
            Console.WriteLine("Cutting the {0}...", vegetable.Name);
            vegetable.IsCut = true;
            return vegetable;
        }
    }
}
