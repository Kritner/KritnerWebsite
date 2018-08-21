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

            CostSolar100Percent = CalculateTotalCost(1);
            CostSolar90Percent = CalculateTotalCost(0.9);
            CostSolar80Percent = CalculateTotalCost(0.8);
        }

        public int PurchaseYear { get; }
        public double CostSolar100Percent { get; }
        public double CostSolar90Percent { get; }
        public double CostSolar80Percent { get; }

        public IYearlyKwhUsage SolarProjection { get; }
        
        public double CalculateTotalCost(double solarGenerationPercentage)
        {
            return TotalCost * (1 - solarGenerationPercentage) + SolarProjection.TotalCost;
        }
}
}
