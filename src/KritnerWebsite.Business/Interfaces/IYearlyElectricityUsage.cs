namespace KritnerWebsite.Business.Models
{
    public interface IYearlyElectricityUsage
    {
        double AverageCostKiloWattHour { get; }
        double AverageCostPerMonth { get; }
        double TotalCost { get; }
        int TotalKiloWattHours { get; }
    }
}