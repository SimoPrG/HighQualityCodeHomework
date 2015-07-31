namespace Exceptions.Utils
{
    using System;
    using System.Collections.Generic;

    public static class ArrayUtils
    {
        public static T[] GetSubsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("array", "Array cannot be null.");
            }

            if (startIndex < 0 || startIndex >= arr.Length)
            {
                throw new IndexOutOfRangeException("Start index must be in range [0, arr.Length).");
            }

            if (count < 0)
            {
                throw new ArgumentException("Length of subsequence cannot be negative.", "substring length");
            }

            if (startIndex + count > arr.Length)
            {
                throw new ArgumentOutOfRangeException("substring length", "The length of the subsequence is too big.");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }
    }
}
