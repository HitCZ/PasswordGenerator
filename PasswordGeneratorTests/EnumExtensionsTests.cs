using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordGenerator.Other.Enums;
using PasswordGenerator.Other.Extensions;

namespace PasswordGeneratorTests
{
    [TestClass]
    public class EnumExtensionsTests
    {
        [TestMethod]
        public void GetAllValueDescriptionsTest()
        {
            var v = EnumExtensions<Amount>.GetAllValueDescriptions();
        }

        public void GetEnumDescriptionTest()
        {

        }

        private enum Empty
        {
        }

        private enum WithoutDescription
        {
            Val1,
            Val2
        }
    }
}
