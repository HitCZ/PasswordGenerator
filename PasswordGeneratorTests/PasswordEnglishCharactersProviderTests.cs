using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordGenerator.Providers;
using System.Collections.Generic;

namespace PasswordGeneratorTests
{
    [TestClass]
    public class PasswordEnglishCharactersProviderTests
    {
        [TestMethod]
        public void GetElementsTest()
        {
            var provider = new PasswordEnglishCharactersProvider();
            var testConfigs = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 100, 1000 };

            foreach (var config in testConfigs)
            {
                var expected = config;
                var actual = provider.GetElements(config).Count;

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void GetElementsCapitalTest()
        {
            var provider = new PasswordEnglishCharactersProvider();
            var testConfigs = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 100, 1000 };

            foreach (var config in testConfigs)
            {
                var expected = config;
                var actual = provider.GetElements(config, true);
                var actualCount = actual.Count;

                foreach (var strChar in actual)
                {
                    if (strChar.Length != 1)
                        Assert.Fail();
                    var actualChar = strChar[0];
                    Assert.IsTrue(char.IsUpper(actualChar));
                }
                Assert.AreEqual(expected, actualCount);
            }
        }
    }
}
