using Microsoft.AspNetCore.Mvc;
using Mike01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mike01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Grades")]
        public IActionResult Grades()
        {
            return View();
        }
        [HttpPost("Grades")]
        public IActionResult Grades(GradesModel model)
        {
            return View();

        }
    }
}
