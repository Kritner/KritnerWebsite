using System.Collections.Generic;
using System.Linq;

namespace KritnerWebsite.Business.Models
{
    public class YearlyElectricityUsageFromMonthly : IYearlyElectricityUsage
    {
        public YearlyElectricityUsageFromMonthly(List<MonthlyElectrictyUsage> monthlyUsage)
        {
            MonthlyUsage = monthlyUsage;
        }

        public List<MonthlyElectrictyUsage> MonthlyUsage { get; }
        public double AverageCostKiloWattHour => MonthlyUsage.Average(a => a.CostPerKiloWattHour);
        public double AverageCostPerMonth => TotalCost / MonthlyUsage.Count;
        public double TotalCost => MonthlyUsage.Sum(s => s.Cost);
        public int TotalKiloWattHours => MonthlyUsage.Sum(s => s.KiloWattHours);

    }
}
