namespace KritnerWebsite.Business.Interfaces
{
    public interface IYearlyKwhUsageCompare : IYearlyKwhUsage
    {
        int PurchaseYear { get; }
        IYearlyKwhUsage SolarProjection { get; }
    }
}
