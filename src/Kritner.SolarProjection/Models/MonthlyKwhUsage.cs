using System;
using System.Collections.Generic;
using System.Text;

namespace Kritner.SolarProjection.Models
{
    public class MonthlyKwhUsage
    {
        public MonthlyKwhUsage(DateTime billingPeriodStart, int kiloWattHours, double cost)
        {
            BillingPeriodStart = billingPeriodStart;
            KiloWattHours = kiloWattHours;
            Cost = cost;
        }

        public DateTime BillingPeriodStart { get; }
        public int KiloWattHours { get; }
        public double Cost { get; }
        public double CostPerKiloWattHour => Cost / KiloWattHours;
    }
}
