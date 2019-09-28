using ConstantsFile = PasswordGenerator.Other.Constants.Constants;

namespace PasswordGenerator.Other.Validators
{
    public class PasswordParametersValidator
    {
        public (bool isValid, string message) ValidateParameters(PasswordParameters parameters)
        {
            var pwLength = parameters.PasswordLength;
            var numbersExactCount = parameters.ExactNumbersCount;
            var specialCharsExactCount = parameters.ExactSpecialCharactersCount;
            var lowerEnglishCharsExactCount = parameters.ExactLowerAlphabetCount;
            var upperEnglishCharsExactCount = parameters.ExactUpperAlphabetCount;

            if (pwLength <= 0 || numbersExactCount == 0 
                              && specialCharsExactCount == 0 
                              && lowerEnglishCharsExactCount == 0
                              && upperEnglishCharsExactCount == 0)
                return (false, ConstantsFile.PasswordLengthIsZero);

            var elementsSum = numbersExactCount 
                            + specialCharsExactCount 
                            + lowerEnglishCharsExactCount 
                            + upperEnglishCharsExactCount;

            if (pwLength < elementsSum)
                return (
                        false,
                        string.Format(ConstantsFile.PasswordElementsCountIsHigherThanLength, elementsSum, pwLength)
                       );
            if (pwLength > elementsSum)
                return (
                        false,
                        string.Format(ConstantsFile.PasswordLengthIsHigherThanElementCount, pwLength, elementsSum)
                       );
            return (true, null);
        }
    }
}
