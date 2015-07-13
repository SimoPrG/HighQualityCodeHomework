namespace ChefInCSharp
{
    using System;

    internal class Bowl
    {
        internal void Add(Vegetable vegetable)
        {
            Console.WriteLine("Adding the {0} in the bowl...", vegetable.Name);
        }
    }
}
