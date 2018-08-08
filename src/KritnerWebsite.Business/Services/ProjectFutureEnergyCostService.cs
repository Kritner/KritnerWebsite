using KritnerWebsite.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KritnerWebsite.Business.Services
{
    public class ProjectFutureEnergyCostService
    {
        public SolarBgeProjection CalculateFutureProjection(
            YearlyElectricityUsage solarEstimate, 
            ProjectionParameters projectionParameters
        )
        {
            var projection = new Dictionary<int, YearlyElectricityUsage>();
            var hold = projectionParameters.OriginalYearlyUsage;
            projection.Add(0, hold);

            // Each year to project
            for (int i = 1; i < projectionParameters.YearsToProject; i++)
            {
                var monthlyUsage = new List<MonthlyElectrictyUsage>();
                // for each month, create a new month multiplied by the percent increase
                foreach (var month in hold.MonthlyUsage)
                {
                    monthlyUsage.Add(new MonthlyElectrictyUsage(
                        month.BillingPeriodStart, 
                        month.KiloWattHours, 
                        month.Cost + (month.Cost * projectionParameters.PercentIncreasePerYear)
                    ));
                }

                hold = new YearlyElectricityUsage(monthlyUsage);
                projection.Add(i, hold);
            }

            return new SolarBgeProjection(solarEstimate, projection);
        }
    }
}
