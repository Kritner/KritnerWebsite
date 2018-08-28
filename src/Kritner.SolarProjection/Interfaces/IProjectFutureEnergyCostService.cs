using Kritner.SolarProjection.Models;

namespace Kritner.SolarProjection.Interfaces
{
    public interface IProjectFutureEnergyCostService
    {
        SolarVsUtilityProjection CalculateFutureProjection(IYearlyKwhUsage solarEstimate, ProjectionParameters projectionParameters);
    }
}