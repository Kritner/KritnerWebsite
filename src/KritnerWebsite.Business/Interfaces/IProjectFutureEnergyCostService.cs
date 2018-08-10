using KritnerWebsite.Business.Models;

namespace KritnerWebsite.Business.Interfaces
{
    public interface IProjectFutureEnergyCostService
    {
        SolarBgeProjection CalculateFutureProjection(IYearlyElectricityUsage solarEstimate, ProjectionParameters projectionParameters);
    }
}