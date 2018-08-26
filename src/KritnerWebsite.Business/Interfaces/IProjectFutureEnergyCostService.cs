using KritnerWebsite.Business.Models;

namespace KritnerWebsite.Business.Interfaces
{
    public interface IProjectFutureEnergyCostService
    {
        SolarVsUtilityProjection CalculateFutureProjection(IYearlyKwhUsage solarEstimate, ProjectionParameters projectionParameters);
    }
}