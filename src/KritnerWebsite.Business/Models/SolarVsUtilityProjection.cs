using System;
using System.Collections.Generic;
using System.Text;

namespace KritnerWebsite.Business.Models
{
    public class SolarVsUtilityProjection
    {
        public SolarVsUtilityProjection(
            IYearlyKwhUsage solarEstimate, 
            Dictionary<int, IYearlyKwhUsage> futureProjection
        )
        {
            SolarEstimate = solarEstimate;
            FutureProjection = futureProjection;
        }

        public IYearlyKwhUsage SolarEstimate { get; }
        public Dictionary<int, IYearlyKwhUsage> FutureProjection { get; }
    }
}
