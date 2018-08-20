using KritnerWebsite.Business.Helpers;
using KritnerWebsite.Business.Interfaces;
using KritnerWebsite.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KritnerWebsite.Business.Services
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

            // Each year to project
            for (int i = 0; i < projectionParameters.YearsToProject; i++)
            {
                projection.Add(new YearlyKwhUsageCompare(
                    FormulaHelpers.CompoundInterest(utilityEstimate.TotalCost, projectionParameters.PercentIncreasePerYear, 1, i),
                    utilityEstimate.TotalKiloWattHours,
                    i,
                    solarEstimate
                ));
            }

            return new SolarVsUtilityProjection(solarEstimate, projection);
        }
    }
}
