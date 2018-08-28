using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kritner.SolarProjection.Helpers;
using Kritner.SolarProjection.Interfaces;
using Kritner.SolarProjection.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}