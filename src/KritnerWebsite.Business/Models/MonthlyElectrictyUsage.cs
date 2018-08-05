using System;
using System.Collections.Generic;
using System.Text;

namespace KritnerWebsite.Business.Models
{
    public class MonthlyElectrictyUsage
    {
        public MonthlyElectrictyUsage(DateTime billingPeriodStart, int kiloWattHours, decimal cost)
        {
            BillingPeriodStart = billingPeriodStart;
            KiloWattHours = kiloWattHours;
            Cost = cost;
        }

        public DateTime BillingPeriodStart { get; }
        public int KiloWattHours { get; }
        public decimal Cost { get; }
        public decimal CostPerKiloWattHour => Cost / KiloWattHours;
    }
}
