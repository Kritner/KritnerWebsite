using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KritnerWebsite.Business.Helpers;
using KritnerWebsite.Business.Interfaces;
using KritnerWebsite.Business.Models;
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
                ElectricityDataHelper.GetUsageWithPanelsMortgage(),
                new ProjectionParameters(
                    ElectricityDataHelper.GetUsageBge2017(), 25, .3
                )
            );
        }
    }
}