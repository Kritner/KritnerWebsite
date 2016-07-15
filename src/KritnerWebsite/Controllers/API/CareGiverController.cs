using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using KritnerWebsite.Interfaces;

namespace KritnerWebsite.Controllers
{
    [Authorize]
    [Route("api/careGiver")]
    public class CareGiverController : Controller
    {
        private readonly ILogger<CareGiverController> _logger;
        private readonly ICareGiverRepository _repo;

        public CareGiverController(ILogger<CareGiverController> logger, ICareGiverRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        [HttpGet]
        public JsonResult Get()
        {
            var userInfo = _repo.GetUserInformation(User.Identity.Name);
            return Json(userInfo);
        }
    }
}
