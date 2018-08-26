using KritnerWebsite.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KritnerWebsite.Business.Models
{
    public class SolarVsUtilityProjection
    {
        public SolarVsUtilityProjection(
            IYearlyKwhUsage solarEstimate, 
            List<IYearlyKwhUsageCompare> futureProjection
        )
        {
            SolarEstimate = solarEstimate;
            FutureProjection = futureProjection;
        }

        public IYearlyKwhUsage SolarEstimate { get; }
        public List<IYearlyKwhUsageCompare> FutureProjection { get; }
    }
}
