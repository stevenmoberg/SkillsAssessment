﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Test03 : BaseTest
    {
        [TestMethod]
        public void Should_Sum_Even_Numbers()
        {
            // Arrange
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Act
            var actual = SumEvenNumbers(numbers);

            // Assert
            Assert.AreEqual(30, actual);
        }

        int SumEvenNumbers(IEnumerable<int> values)
        {
            // {code} - using Linq to sum all even numbers
            return 0;
        }
    }
}
