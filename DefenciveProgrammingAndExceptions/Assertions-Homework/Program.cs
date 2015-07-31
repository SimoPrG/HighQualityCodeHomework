namespace Assertions
{
    using System;

    public static class Program
    {
        static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            AssertionsUtils.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            AssertionsUtils.SelectionSort(new int[0]); // Test sorting empty array
            AssertionsUtils.SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(AssertionsUtils.BinarySearch(arr, -1000));
            Console.WriteLine(AssertionsUtils.BinarySearch(arr, 0));
            Console.WriteLine(AssertionsUtils.BinarySearch(arr, 17));
            Console.WriteLine(AssertionsUtils.BinarySearch(arr, 10));
            Console.WriteLine(AssertionsUtils.BinarySearch(arr, 1000));
        }
    }
}