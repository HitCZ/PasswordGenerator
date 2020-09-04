using PasswordGenerator.Builders;
using PasswordGenerator.Other;
using PasswordGenerator.Other.Enums;
using PasswordGenerator.Other.Exceptions;
using PasswordGenerator.Other.Validators;

namespace PasswordGenerator.Providers
{
    public class PasswordProvider
    {
        private readonly PasswordParametersValidator validator;
        private readonly PasswordBuilder builder;

        public PasswordProvider()
        {
            validator = new PasswordParametersValidator();
            builder = new PasswordBuilder();
        }

        public string GetPassword(PasswordParameters parameters)
        {
            AdjustParameters(parameters);
            ValidateParameters(parameters);

            var password = builder.BuildPassword(parameters);
            return password;
        }

        private void AdjustParameters(PasswordParameters parameters)
        {
            var numbersAmount = parameters.NumbersAmount;
            var englishCharsAmount = parameters.LowerEnglishAlphabetAmount;
            var specialCharsAmount = parameters.SpecialCharactersAmount;

            if (numbersAmount == Amount.One)
                parameters.ExactNumbersCount = 1;
            if (englishCharsAmount == Amount.One)
                parameters.ExactLowerAlphabetCount = 1;
            if (specialCharsAmount == Amount.One)
                parameters.ExactSpecialCharactersCount = 1;
        }
        
        private void ValidateParameters(PasswordParameters parameters)
        {
            var validatorResult = validator.ValidateParameters(parameters);

            if (validatorResult.isValid)
                return;

            throw new InvalidPasswordParametersException(validatorResult.message);
        }
    }
}
