﻿using Iti.AppDemo.Core.Implementations;
using NUnit.Framework;

namespace Iti.AppDemo.Tests.UnitTesting.Core
{
    public class PasswordRegexTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PasswordRegexTest_TestRegex_ReturnsTrue()
        {
            var password = "@789Aa654";
            var passwordRegex = new PasswordRegex();

            var result = passwordRegex.IsValid(password);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void PasswordRegexTest_TestRegex_ReturnsFalse()
        {
            var password = "@789Aa65414";
            var passwordRegex = new PasswordRegex();

            var result = passwordRegex.IsValid(password);

            Assert.AreEqual(false, result);
        }
    }
}
