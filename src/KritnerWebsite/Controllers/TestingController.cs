using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace KritnerWebsite.Controllers
{
    [Authorize]
    public class TestingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BabyTrackingAngular()
        {
            return View();
        }

        public IActionResult BabyTrackingKnockout()
        {
            return View();
        }

        public IActionResult PluralSightDurandalGetStarted()
        {
            return View();
        }
    }
}
