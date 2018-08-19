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
            var projection = new Dictionary<int, IYearlyKwhUsage>();
            var original = projectionParameters.OriginalYearlyUsage;

            // Each year to project
            for (int i = 0; i < projectionParameters.YearsToProject; i++)
            {
                projection.Add(i, new YearlyKwhUsageFromAnnual(
                    FormulaHelpers.CompoundInterest(original.TotalCost, projectionParameters.PercentIncreasePerYear, 1, i), 
                    original.TotalKiloWattHours
                ));
            }

            return new SolarVsUtilityProjection(solarEstimate, projection);
        }
    }
}
