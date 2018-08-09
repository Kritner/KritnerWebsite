using KritnerWebsite.Business.Helpers;
using KritnerWebsite.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KritnerWebsite.Business.Services
{
    public class ProjectFutureEnergyCostService
    {
        public SolarBgeProjection CalculateFutureProjection(
            IYearlyElectricityUsage solarEstimate, 
            ProjectionParameters projectionParameters
        )
        {
            var projection = new Dictionary<int, IYearlyElectricityUsage>();
            var original = projectionParameters.OriginalYearlyUsage;

            // Each year to project
            for (int i = 0; i < projectionParameters.YearsToProject; i++)
            {
                projection.Add(i, new YearlyElectricityUsageFromAnnual(
                    FormulaHelpers.CompoundInterest(original.TotalCost, projectionParameters.PercentIncreasePerYear, 1, i), 
                    original.TotalKiloWattHours
                ));
            }

            return new SolarBgeProjection(solarEstimate, projection);
        }
    }
}
