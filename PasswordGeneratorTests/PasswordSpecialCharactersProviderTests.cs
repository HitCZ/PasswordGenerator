﻿//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using PasswordGenerator.Providers;
//using System.Collections.Generic;

//namespace PasswordGeneratorTests
//{
//    [TestClass]
//    public class PasswordSpecialCharactersProviderTests
//    {
//        [TestMethod]
//        public void GetElementsTest()
//        {
//            var provider = new PasswordSpecialCharacterProvider();
//            var testConfigs = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 20, 30, 100, 1000 };

//            foreach (var config in testConfigs)
//            {
//                var expected = config;
//                var actual = provider.GetElements(config).Count;

//                Assert.AreEqual(expected, actual);
//            }
//        }
//    }
//}
