using System;
using System.Collections.Generic;
using System.Text;

namespace KritnerWebsite.Business.Models
{
    public class SolarBgeProjection
    {
        public SolarBgeProjection(
            IYearlyElectricityUsage solarEstimate, 
            Dictionary<int, IYearlyElectricityUsage> bgeFutureProjection
        )
        {
            SolarEstimate = solarEstimate;
            BgeFutureProjection = bgeFutureProjection;
        }

        public IYearlyElectricityUsage SolarEstimate { get; }
        public Dictionary<int, IYearlyElectricityUsage> BgeFutureProjection { get; }
    }
}
