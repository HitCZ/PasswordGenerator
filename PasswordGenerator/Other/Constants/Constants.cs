namespace PasswordGenerator.Other.Constants
{
    internal static class Constants
    {
        public const string PasswordLengthIsZero = "Password has to contain at least one element!";
        public const string PasswordElementsCountIsHigherThanLength =
            "Password contains more elements ({0}), than it's set length ({1})!";
        public const string PasswordLengthIsHigherThanElementCount
            = "Password length ({0}) is higher than the count of elements ({1})!";

    }
}
