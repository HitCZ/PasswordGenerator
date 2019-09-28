using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordGenerator.Builders;
using PasswordGenerator.Other;

namespace PasswordGeneratorTests
{
    [TestClass]
    public class PasswordBuilderTests
    {
        [TestMethod]
        public void BuildPasswordTest()
        {
            var builder = new PasswordBuilder();
            var parameters = new PasswordParameters
            {
                PasswordLength = 7,
                ExactSpecialCharactersCount = 2,
                ExactNumbersCount = 2,
                ExactLowerAlphabetCount = 3
            };

            var passwords = new List<string>();

            for (int i = 0; i < 4; i++)
            {
                passwords.Add(builder.BuildPassword(parameters));
            }

            
        }
    }
}
