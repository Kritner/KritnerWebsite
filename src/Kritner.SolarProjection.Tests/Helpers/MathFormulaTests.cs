using Kritner.SolarProjection.Helpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kritner.SolarProjection.Tests.Helpers
{
    [TestFixture]
    public class MathFormulaTests
    {
        [Test]
        // 5000 + (5000 * .1)
        // = 5000 + 500
        // = 5500
        [TestCase(
            5000,
            .1,
            1,
            1,
            5500
        )]
        // 5000 + (5000 * .1)
        // = 5000 + 500
        // = 5500 + (5500 * .1)
        // = 5500 + 550
        // = 6050
        [TestCase(
            5000,
            .1,
            1,
            2,
            6050
        )]
        public void ShouldCalculateCorrectInterest(
            double principal, 
            double interestRate, 
            int compoundsPerYear, 
            int timeInYears, 
            double expectedAmount
        )
        {
            var result = FormulaHelpers.CompoundInterest(principal, interestRate, compoundsPerYear, timeInYears);
            Assert.AreEqual(expectedAmount, result, .01);
        }
    }
}
