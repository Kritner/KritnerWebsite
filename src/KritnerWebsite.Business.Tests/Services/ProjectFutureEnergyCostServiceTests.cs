using KritnerWebsite.Business.Models;
using KritnerWebsite.Business.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace KritnerWebsite.Business.Tests.Services
{
    [TestFixture]
    public class ProjectFutureEnergyCostServiceTests
    {
        private readonly ProjectFutureEnergyCostService _subject = new ProjectFutureEnergyCostService();
        private const int ORIGINAL_KWH = 1000;
        private const int PERCENT_INCREASE_PER_YEAR = 10;
        private const decimal ORIGINAL_COST = 100;
        
        [Test]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(10)]
        public void ShouldProjectCorrectNumberOfYears(int yearsToProject)
        {
            var result = _subject.CalculateFutureProjection(
                GetSampleData(), 
                new ProjectionParameters(GetSampleData(), yearsToProject, PERCENT_INCREASE_PER_YEAR)
            );

            Assert.AreEqual(yearsToProject, result.BgeFutureProjection.Count, nameof(yearsToProject));
        }

        [Test]
        [TestCase(5)]
        public void ShouldIncreaseProjectionByCorrectAmount(int yearsToProject)
        {
            var result = _subject.CalculateFutureProjection(
                GetSampleData(),
                new ProjectionParameters(GetSampleData(), yearsToProject, PERCENT_INCREASE_PER_YEAR)
            );

            var sample = GetSampleData();
            Assert.AreEqual(sample.AverageCostPerMonth, result.BgeFutureProjection[0].AverageCostPerMonth, $"Index 0 should be unchanged");
            for (int i = 1; i < yearsToProject; i++)
            {
                // TODO
                throw new NotImplementedException()
            }
        }

        private static YearlyElectricityUsage GetSampleData()
        {
            return new YearlyElectricityUsage(new List<MonthlyElectrictyUsage>()
            {
                new MonthlyElectrictyUsage(new DateTime(), ORIGINAL_KWH, ORIGINAL_COST)
            });
        }
    }
}
