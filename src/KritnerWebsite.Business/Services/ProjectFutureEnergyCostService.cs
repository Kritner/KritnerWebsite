using KritnerWebsite.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace KritnerWebsite.Business.Services
{
    public class ProjectFutureEnergyCostService
    {
        public SolarBgeProjection CalculateFutureProjection(YearlyElectricityUsage solarEstimate, ProjectionParameters projectionParameters)
        {
            var hold = projectionParameters.OriginalYearlyUsage;
            for (int i = 0; i < projectionParameters.YearsToProject; i++)
            {
                foreach (var item in hold.MonthlyUsage)
                {
                    // TODO: the thing
                    throw new NotImplementedException();
                }
            }

            return new SolarBgeProjection(solarEstimate, null);
        }
    }
}
