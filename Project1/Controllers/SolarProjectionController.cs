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

        /// <summary>
        /// Get solar projection with a json 
        /// string representing <see cref="SolarProjectionParameters"/>.
        /// 
        /// TODO there's gotta be a better way to do this signature,
        /// both from a param and return perspective.  I feel like
        /// parameter should convey the proper type, and the result
        /// should be able to convey a status perhaps?
        /// </summary>
        /// <param name="param">Json representation of <see cref="SolarProjectionParameters"/></param>
        /// <returns><see cref="SolarVsUtilityProjection"/></returns>
        [HttpGet]
        public SolarVsUtilityProjection Get(string param)
        {
            // Convert json string to type
            var solarProjectionParameters = JsonConvert
                .DeserializeObject<SolarProjectionParameters>(param);
            
            // Calculate future projection
            return _service.CalculateFutureProjection(
                solarEstimate: new YearlyKwhUsageFromAnnual(
                    totalCost: solarProjectionParameters.SolarCostPerMonth * 12,
                    totalKiloWattHours: solarProjectionParameters.UtilitySolarArrayKwhYear
                ),
                projectionParameters: new ProjectionParameters(
                    utilityYear: new YearlyKwhUsageFromAnnual(
                        totalCost: solarProjectionParameters.UtilityCostFullYear,
                        totalKiloWattHours: solarProjectionParameters.UtilitySolarArrayKwhYear
                    ),
                    yearsToProject: solarProjectionParameters.YearsToProject,
                    financeYears: solarProjectionParameters.SolarFinanceYears,
                    percentIncreasePerYear: solarProjectionParameters.UtilityPercentIncreasePerYear
                )
            );
        }
    }
}