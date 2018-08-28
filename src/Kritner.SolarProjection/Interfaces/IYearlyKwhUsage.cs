namespace Kritner.SolarProjection.Interfaces
{
    public interface IYearlyKwhUsage
    {
        double AverageCostKiloWattHour { get; }
        double AverageCostPerMonth { get; }
        double TotalCost { get; }
        int TotalKiloWattHours { get; }
    }
}