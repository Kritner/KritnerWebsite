using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KritnerWebsite.Controllers
{
    public class TestingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BabyTracking()
        {
            return View();
        }
    }
}
