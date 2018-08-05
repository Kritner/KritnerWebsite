using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace KritnerWebsite.Business.Models
{
    public class YearlyElectricityUsage
    {
        public YearlyElectricityUsage(List<MonthlyElectrictyUsage> monthlyUsage)
        {
            MonthlyUsage = monthlyUsage;
        }

        public List<MonthlyElectrictyUsage> MonthlyUsage { get; }
        public int TotalKiloWattHours => MonthlyUsage.Sum(s => s.KiloWattHours);
        public decimal TotalCost => MonthlyUsage.Sum(s => s.Cost);
        public decimal AverageCostKiloWattHour => MonthlyUsage.Average(a => a.CostPerKiloWattHour);
        public decimal AverageCostPerMonth => TotalCost / MonthlyUsage.Count;
    }
}
