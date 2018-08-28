using Kritner.SolarProjection.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kritner.SolarProjection.Tests.Models
{
    [TestFixture]
    public class YearlyKwhUsageTestsFromMonthly
    {
        private YearlyKwhUsageFromMonthly _subject;

        [Test]
        public void ShouldMatchActualUsageFromSampleData()
        {
            // Note duplicate of static data defined in ElectricityDataHelper.GetUsageBge2017
            // Defining here in case that data is ever changed
            List<MonthlyKwhUsage> monthlyCollection2017 = new List<MonthlyKwhUsage>()
            {
                new MonthlyKwhUsage(new DateTime(2017, 1, 1), 1279, 184.03),
                new MonthlyKwhUsage(new DateTime(2017, 2, 1), 1035, 152.21),
                new MonthlyKwhUsage(new DateTime(2017, 3, 1), 1063, 153.65),
                new MonthlyKwhUsage(new DateTime(2017, 4, 1), 1075, 157.43),
                new MonthlyKwhUsage(new DateTime(2017, 5, 1), 1123, 164.07),
                new MonthlyKwhUsage(new DateTime(2017, 6, 1), 1986, 271.40),
                new MonthlyKwhUsage(new DateTime(2017, 7, 1), 2191, 296.36),
                new MonthlyKwhUsage(new DateTime(2017, 8, 1), 1926, 261.51),
                new MonthlyKwhUsage(new DateTime(2017, 9, 1), 1673, 223.58),
                new MonthlyKwhUsage(new DateTime(2017, 10, 1), 1196, 161.04),
                new MonthlyKwhUsage(new DateTime(2017, 11, 1), 1201, 161.50),
                new MonthlyKwhUsage(new DateTime(2017, 12, 1), 1271, 170.44)
            };

            _subject = new YearlyKwhUsageFromMonthly(monthlyCollection2017);

            // Pulling expected values from spreadsheet calculations
            Assert.AreEqual(17019, _subject.TotalKiloWattHours, nameof(_subject.TotalKiloWattHours));
            Assert.AreEqual(2357.22, _subject.TotalCost, nameof(_subject.TotalCost));
            Assert.AreEqual(196.435, _subject.AverageCostPerMonth, .01, nameof(_subject.AverageCostPerMonth));
            Assert.AreEqual(0.1385052001, _subject.AverageCostKiloWattHour, .01, nameof(_subject.AverageCostKiloWattHour));
        }
    }
}
