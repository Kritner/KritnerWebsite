﻿using KritnerWebsite.Business.Interfaces;
using System;
using System.Text;

namespace KritnerWebsite.Business.Models
{
    public class YearlyKwhUsageFromAnnual : IYearlyKwhUsage
    {
        public YearlyKwhUsageFromAnnual(double totalCost, int totalKiloWattHours)
        {
            TotalCost = totalCost;
            TotalKiloWattHours = totalKiloWattHours;
        }

        public double AverageCostKiloWattHour => TotalCost / TotalKiloWattHours;
        public double AverageCostPerMonth => TotalCost / 12;
        public double TotalCost { get; private set; }
        public int TotalKiloWattHours { get; private set; }
    }
}