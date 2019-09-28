using System;
using System.Collections.Generic;
using System.Text;
using PasswordGenerator.Other;
using PasswordGenerator.Providers;

namespace PasswordGenerator.Builders
{
    public class PasswordBuilder
    {
        private readonly IPasswordElementProvider numbersProvider;
        private readonly IPasswordElementProvider specialCharactersProvider;
        private readonly IPasswordElementProvider englishAlphabetProvider;
        private readonly Random random;

        public PasswordBuilder()
        {
            numbersProvider = new PasswordNumberProvider();
            specialCharactersProvider = new PasswordSpecialCharacterProvider();
            englishAlphabetProvider = new PasswordEnglishAlphabetProvider();
            random = new Random();
        }

        public string BuildPassword(PasswordParameters parameters)
        {
            var pwLength = parameters.PasswordLength;
            var sb = new StringBuilder(pwLength);
            var numbersExactCount = parameters.ExactNumbersCount;
            var specialCharsExactCount = parameters.ExactSpecialCharactersCount;
            var lowerEnglishCharsExactCount = parameters.ExactLowerAlphabetCount;
            var upperEnglishCharsExactCount = parameters.ExactUpperAlphabetCount;

            var elementsFromProviders = new List<string>();
            var numbersFromProvider = numbersProvider.GetElements(numbersExactCount);
            var specialCharactersFromProvider = specialCharactersProvider.GetElements(specialCharsExactCount);
            var lowerEnglishCharactersFromProvider = englishAlphabetProvider.GetElements(lowerEnglishCharsExactCount);
            var upperEnglishCharactersFromProvider
                                                   = (englishAlphabetProvider as PasswordEnglishAlphabetProvider)?
                                                    .GetElements(upperEnglishCharsExactCount, true);

            elementsFromProviders.AddRange(numbersFromProvider);
            elementsFromProviders.AddRange(specialCharactersFromProvider);
            elementsFromProviders.AddRange(lowerEnglishCharactersFromProvider);

            if (!(upperEnglishCharactersFromProvider is null))
                elementsFromProviders.AddRange(upperEnglishCharactersFromProvider);

            for (var i = 0; i < pwLength; i++)
            {
                var randomIndex = random.Next(elementsFromProviders.Count);
                var randomElement = elementsFromProviders[randomIndex];
                elementsFromProviders.Remove(randomElement);
                sb.Append(randomElement);
            }

            return sb.ToString();
        }
    }
}
