using KritnerWebsite.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KritnerWebsite.Business.Models
{
    public class YearlyKwhUsageCompare : YearlyKwhUsageFromAnnual, IYearlyKwhUsageCompare
    {
        public YearlyKwhUsageCompare(
            double totalCost, 
            int totalKiloWattHours, 
            int purchaseYear, 
            IYearlyKwhUsage solarProjection
        ) 
            : base(totalCost, totalKiloWattHours)
        {
            PurchaseYear = purchaseYear;
            SolarProjection = solarProjection;
        }

        public int PurchaseYear { get; }

        public IYearlyKwhUsage SolarProjection { get; }
    }
}
