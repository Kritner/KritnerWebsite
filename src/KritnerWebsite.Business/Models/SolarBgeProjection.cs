using System;
using System.Collections.Generic;
using System.Text;

namespace KritnerWebsite.Business.Models
{
    public class SolarBgeProjection
    {
        public SolarBgeProjection(
            YearlyElectricityUsage solarEstimate, 
            Dictionary<int, YearlyElectricityUsage> bgeFutureProjection
        )
        {
            SolarEstimate = solarEstimate;
            BgeFutureProjection = bgeFutureProjection;
        }

        public YearlyElectricityUsage SolarEstimate { get; }
        public Dictionary<int, YearlyElectricityUsage> BgeFutureProjection { get; }
    }
}
