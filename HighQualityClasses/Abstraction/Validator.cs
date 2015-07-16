namespace Abstraction
{
    using System;

    internal static class Validator
    {
        internal static void ValidatePropertyValue(double propertyValue, string propertyName)
        {
            if (propertyValue <= 0)
            {
                throw new ArgumentException(propertyName + " must be positive.", propertyName);
            }
        }
    }
}
