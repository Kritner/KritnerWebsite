using KritnerWebsite.Business.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace KritnerWebsite.Business.Tests.Models
{
    [TestFixture]
    public class YearlyElectricityUsageTests
    {
        private YearlyElectricityUsage _subject;

        [Test]
        public void ShouldMatchActualUsageFromSampleData()
        {
            // Note duplicate of static data defined in ElectricityDataHelper.GetUsageBge2017
            // Defining here in case that data is ever changed
            List<MonthlyElectrictyUsage> monthlyCollection2017 = new List<MonthlyElectrictyUsage>()
            {
                new MonthlyElectrictyUsage(new DateTime(2017, 1, 1), 1279, 184.03m),
                new MonthlyElectrictyUsage(new DateTime(2017, 2, 1), 1035, 152.21m),
                new MonthlyElectrictyUsage(new DateTime(2017, 3, 1), 1063, 153.65m),
                new MonthlyElectrictyUsage(new DateTime(2017, 4, 1), 1075, 157.43m),
                new MonthlyElectrictyUsage(new DateTime(2017, 5, 1), 1123, 164.07m),
                new MonthlyElectrictyUsage(new DateTime(2017, 6, 1), 1986, 271.40m),
                new MonthlyElectrictyUsage(new DateTime(2017, 7, 1), 2191, 296.36m),
                new MonthlyElectrictyUsage(new DateTime(2017, 8, 1), 1926, 261.51m),
                new MonthlyElectrictyUsage(new DateTime(2017, 9, 1), 1673, 223.58m),
                new MonthlyElectrictyUsage(new DateTime(2017, 10, 1), 1196, 161.04m),
                new MonthlyElectrictyUsage(new DateTime(2017, 11, 1), 1201, 161.50m),
                new MonthlyElectrictyUsage(new DateTime(2017, 12, 1), 1271, 170.44m)
            };

            _subject = new YearlyElectricityUsage(monthlyCollection2017);

            // Pulling expected values from spreadsheet calculations
            Assert.AreEqual(17019, _subject.TotalKiloWattHours, nameof(_subject.TotalKiloWattHours));
            Assert.AreEqual(2357.22, _subject.TotalCost, nameof(_subject.TotalCost));
            Assert.AreEqual(196.435, _subject.AverageCostPerMonth, nameof(_subject.AverageCostPerMonth));
            Assert.AreEqual(Math.Round(0.1385052001m, 3), Math.Round(_subject.AverageCostKiloWattHour, 3), nameof(_subject.AverageCostKiloWattHour));
        }
    }
}
