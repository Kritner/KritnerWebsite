using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kritner.SolarProjection.Helpers;
using Kritner.SolarProjection.Interfaces;
using Kritner.SolarProjection.Models;
using KritnerWebsite.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace KritnerWebsite.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolarProjectionController : ControllerBase
    {
        private readonly IProjectFutureEnergyCostService _service;

        public SolarProjectionController(IProjectFutureEnergyCostService service)
        {
            _service = service;
        }

        [HttpGet("[action]")]
        public SolarVsUtilityProjection GetProjection()
        {
            return _service.CalculateFutureProjection(
                ElectricityDataHelper.GetUsageWithPanelsMortgageAnnual(),
                new ProjectionParameters(
                    ElectricityDataHelper.GetUsageUtility2017FromAnnual(), 
                    25, 
                    20,
                    .03
                )
            );
        }

        [HttpGet]
        public SolarVsUtilityProjection Get(string param)
        {
            var solarProjectionParameters = JsonConvert
                .DeserializeObject<SolarProjectionParameters>(param);
                
            return _service.CalculateFutureProjection(
                new YearlyKwhUsageFromAnnual(
                    solarProjectionParameters.SolarCostPerMonth * 12,
                    solarProjectionParameters.UtilitySolarArrayKwhYear
                ),
                new ProjectionParameters(
                    new YearlyKwhUsageFromAnnual(
                        solarProjectionParameters.UtilityCostFullYear, 
                        solarProjectionParameters.UtilitySolarArrayKwhYear
                    ),
                    solarProjectionParameters.YearsToProject,
                    solarProjectionParameters.SolarFinanceYears,
                    solarProjectionParameters.UtilityPercentIncreasePerYear
                )
            );
        }
    }
}