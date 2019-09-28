using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordGenerator.Other;
using PasswordGenerator.Other.Enums;
using PasswordGenerator.Providers;
using System.Collections.Generic;

namespace PasswordGeneratorTests
{
    [TestClass]
    public class PasswordProviderTests
    {
        [TestMethod]
        public void GetPasswordTest()
        {
            var provider = new PasswordProvider();
            var parameters = new PasswordParameters
            {
                LowerEnglishAlphabetAmount = Amount.ExactAmount,
                UpperEnglishAlphabetAmount = Amount.ExactAmount,
                SpecialCharactersAmount = Amount.ExactAmount,
                NumbersAmount = Amount.ExactAmount,
                ExactNumbersCount = 3,
                ExactLowerAlphabetCount = 4,
                ExactUpperAlphabetCount = 2,
                ExactSpecialCharactersCount = 1,
                PasswordLength = 11
            };
            var passwords = new List<string>();

            for (int i = 0; i < 50; i++)
            {
                passwords.Add(provider.GetPassword(parameters));
            }
        }
    }
}
