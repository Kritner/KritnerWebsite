using KritnerWebsite.Business.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace KritnerWebsite.Business.Tests.Models
{
    [TestFixture]
    public class MonthlyElectricityUsageTests
    {
        private MonthlyElectrictyUsage _subject;

        [Test]
        [TestCase(100, .1, .001)]
        [TestCase(100, 1, .01)]
        [TestCase(2000, 150, .075)]
        public void ShouldCalculateCorrectCostPerKiloWattHour(
            int kiloWattHours, 
            double cost, 
            double expectedCostPerKiloWattHour
        )
        {
            _subject = new MonthlyElectrictyUsage(new DateTime(), kiloWattHours, cost);
            Assert.AreEqual(expectedCostPerKiloWattHour, _subject.CostPerKiloWattHour);
        }
    }
}
