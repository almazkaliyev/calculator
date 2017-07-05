﻿using Calculator.TwoArgumentFactory;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class DivisionCalculatorTest
    {
        [TestCase(21, 3, 7)]
        [TestCase(9, 4, 2.25)]
        [TestCase(-9, 3, -3)]
        public void FirstDivisonSecondAreEqualTo(double firstValue, double secondValue, double expected)
        {
            var divisionCalculator = new DivisionCalculator();
            var actualResult = divisionCalculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}