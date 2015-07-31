namespace Exceptions.Utils
{
    using System;
    using System.Text;

    public static class StringUtils
    {
        public static string ExtractEnding(string str, int count)
        {
            if (str == null)
            {
                throw new ArgumentNullException("input string", "String cannot be null.");
            }

            if (count > str.Length)
            {
                throw new ArgumentOutOfRangeException("substring length", "Count cannot be greater than string length.");
            }

            if (count > str.Length)
            {
                return "Invalid count!";
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }
    }
}
