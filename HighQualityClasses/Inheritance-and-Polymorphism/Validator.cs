namespace InheritanceAndPolymorphism
{
    using System;

    internal static class Validator
    {
        internal static void ValidateName(string name, string properyName)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(properyName + " cannot be null or white space", properyName);
            }
        }

        internal static void ValidateObjectIsNotNull(object obj, string objectName)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(objectName, objectName + "cannot be null");
            }
        }
    }
}
