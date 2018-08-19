using System;
using System.Collections.Generic;
using System.Text;

namespace KritnerWebsite.Business.Models
{
    public class SolarVsUtilityProjection
    {
        public SolarVsUtilityProjection(
            IYearlyKwhUsage solarEstimate, 
            Dictionary<int, IYearlyKwhUsage> bgeFutureProjection
        )
        {
            SolarEstimate = solarEstimate;
            BgeFutureProjection = bgeFutureProjection;
        }

        public IYearlyKwhUsage SolarEstimate { get; }
        public Dictionary<int, IYearlyKwhUsage> BgeFutureProjection { get; }
    }
}
