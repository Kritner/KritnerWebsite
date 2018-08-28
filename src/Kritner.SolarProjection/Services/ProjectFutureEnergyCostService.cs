using Kritner.SolarProjection.Helpers;
using Kritner.SolarProjection.Interfaces;
using Kritner.SolarProjection.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kritner.SolarProjection.Services
{
    public class ProjectFutureEnergyCostService : IProjectFutureEnergyCostService
    {
        public SolarVsUtilityProjection CalculateFutureProjection(
            IYearlyKwhUsage solarEstimate, 
            ProjectionParameters projectionParameters
        )
        {
            var projection = new List<IYearlyKwhUsageCompare>();
            var utilityEstimate = projectionParameters.UtilityYear;

            var paidOffSolarEstimate = new YearlyKwhUsageFromAnnual(
                0, solarEstimate.TotalKiloWattHours
            );

            // Each year to project
            for (int i = 0; i < projectionParameters.YearsToProject; i++)
            {
                projection.Add(new YearlyKwhUsageCompare(
                    FormulaHelpers.CompoundInterest(utilityEstimate.TotalCost, projectionParameters.PercentIncreasePerYear, 1, i),
                    utilityEstimate.TotalKiloWattHours,
                    i,
                    // After financeYears, solar panels are no longer paid for
                    i < projectionParameters.FinanceYears ? 
                        solarEstimate : paidOffSolarEstimate
                ));
            }

            return new SolarVsUtilityProjection(solarEstimate, projection, projectionParameters.FinanceYears);
        }
    }
}
