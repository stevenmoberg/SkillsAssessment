﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_PhoneNumbers
    {
        [Medium]
        [TestMethod]
        public void Should_Format_PhoneNumbers()
        {
            Assert.AreEqual("(987) 123-4567", Format("987-123-4567"));
            Assert.AreEqual("(123) 456-7890", Format("123 456 7890"));
            Assert.AreEqual("(123) 456-7890", Format("(123)456-7890"));
            Assert.AreEqual("(123) 456-7890", Format("(123) 456-7890"));
            Assert.AreEqual("(123) 456-7890", Format("1234567890"));
            Assert.AreEqual("465-4879", Format("4564879"));
            Assert.AreEqual("", "456789");
        }

        /// <summary>
        /// Clean and format valid phone number
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        string Format(string phone)
        {
            // format phone number as (xxx) xxx-xxxx
            return string.Empty;
        }
    }
}
