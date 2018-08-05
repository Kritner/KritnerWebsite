using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace KritnerWebsite.Business.Models
{
    public class YearlyElectricityUsage
    {
        public List<MonthlyElectrictyUsage> MonthlyUsage { get; set; } = new List<MonthlyElectrictyUsage>();
        public int TotalKiloWattHours => MonthlyUsage.Sum(s => s.KiloWattHours);
        public decimal TotalCost => MonthlyUsage.Sum(s => s.Cost);
        public decimal AverageCostKiloWattHour => MonthlyUsage.Average(a => a.CostPerKiloWattHour);
        public decimal AverageCostPerMonth => TotalCost / AverageCostKiloWattHour;
    }
}
