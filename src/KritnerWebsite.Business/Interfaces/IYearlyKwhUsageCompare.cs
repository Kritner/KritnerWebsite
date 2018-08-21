namespace KritnerWebsite.Business.Interfaces
{
    public interface IYearlyKwhUsageCompare : IYearlyKwhUsage
    {
        int PurchaseYear { get; }
        IYearlyKwhUsage SolarProjection { get; }
        double CostSolar100Percent { get; }
        double CostSolar90Percent { get; }
        double CostSolar80Percent { get; }
    }
}
