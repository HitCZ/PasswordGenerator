using PasswordGenerator.Builders;
using PasswordGenerator.Other;
using PasswordGenerator.Other.Enums;
using PasswordGenerator.Other.Exceptions;
using PasswordGenerator.Other.Validators;
using System;

namespace PasswordGenerator.Providers
{
    public class PasswordProvider
    {
        private readonly PasswordParametersValidator validator;
        private readonly PasswordBuilder builder;
        private readonly Random random;

        public PasswordProvider()
        {
            validator = new PasswordParametersValidator();
            builder = new PasswordBuilder();
            random = new Random();
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

            //var operationIndex = random.Next(3);

            //switch (operationIndex)
            //{
            //    case 0:
            //        SetNumbersRandomAmount(parameters, numbersAmount);
            //        break;
            //    case 1:
            //        SetEnglishCharsRandomAmount(parameters, englishCharsAmount);
            //        break;
            //    case 2:
            //        SetSpecialCharsRandomAmount(parameters, specialCharsAmount);
            //        break;
            //}
        }

        //private void SetSpecialCharsRandomAmount(PasswordParameters parameters, Amount specialCharsAmount)
        //{
        //    var currentPasswordLength = GetCurrentPasswordLength(parameters);
        //    var remainingSpace = GetRemainingLength(currentPasswordLength, parameters.PasswordLength);

        //    if (specialCharsAmount != Amount.RandomAmount)
        //        return;

        //    var randomAmount = random.Next(remainingSpace);
        //    parameters.ExactSpecialCharactersCount = randomAmount;
        //}

        //private void SetEnglishCharsRandomAmount(PasswordParameters parameters, Amount englishCharsAmount)
        //{
        //    var currentPasswordLength = GetCurrentPasswordLength(parameters);
        //    var remainingSpace = GetRemainingLength(currentPasswordLength, parameters.PasswordLength);

        //    if (englishCharsAmount != Amount.RandomAmount)
        //        return;

        //    var randomAmount = random.Next(remainingSpace);
        //    parameters.ExactLowerAlphabetCount = randomAmount;
        //}

        //private void SetNumbersRandomAmount(PasswordParameters parameters, Amount numbersAmount)
        //{
        //    var currentPasswordLength = GetCurrentPasswordLength(parameters);
        //    var remainingSpace = GetRemainingLength(currentPasswordLength, parameters.PasswordLength);

        //    if (numbersAmount != Amount.RandomAmount)
        //        return;

        //    var randomAmount = random.Next(remainingSpace);
        //    parameters.ExactNumbersCount = randomAmount;
        //}

        //private int GetCurrentPasswordLength(PasswordParameters parameters)
        //{
        //    var result = parameters.ExactNumbersCount
        //               + parameters.ExactLowerAlphabetCount
        //               + parameters.ExactSpecialCharactersCount;

        //    return result;
        //}

        //private int GetRemainingLength(int currentLength, int totalLength)
        //{
        //    var result = totalLength - currentLength;
        //    return result;
        //}

        private void ValidateParameters(PasswordParameters parameters)
        {
            var validatorResult = validator.ValidateParameters(parameters);

            if (validatorResult.isValid)
                return;

            throw new InvalidPasswordParametersException(validatorResult.message);
        }
    }
}
