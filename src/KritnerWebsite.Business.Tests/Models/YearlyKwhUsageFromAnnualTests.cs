using KritnerWebsite.Business.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace KritnerWebsite.Business.Tests.Models
{
    [TestFixture]
    public class YearlyKwhUsageTestsFromAnnual
    {
        private YearlyKwhUsageFromAnnual _subject;

        [Test]
        public void ShouldMatchActualUsageFromSampleData()
        {
            _subject = new YearlyKwhUsageFromAnnual(2357.22, 17019);

            // Pulling expected values from spreadsheet calculations
            Assert.AreEqual(196.435, _subject.AverageCostPerMonth, .01, nameof(_subject.AverageCostPerMonth));
            Assert.AreEqual(0.1385052001, _subject.AverageCostKiloWattHour, .01, nameof(_subject.AverageCostKiloWattHour));
        }
    }
}
