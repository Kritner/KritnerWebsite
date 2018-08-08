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
        public double TotalCost => MonthlyUsage.Sum(s => s.Cost);
        public double AverageCostKiloWattHour => MonthlyUsage.Average(a => a.CostPerKiloWattHour);
        public double AverageCostPerMonth => TotalCost / MonthlyUsage.Count;
    }
}
