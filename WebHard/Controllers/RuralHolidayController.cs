using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebHard.Models;

namespace WebHard.Controllers
{
    public class RuralHolidayController : Controller
    {
        private readonly ILogger<RuralHolidayController> _logger;

        public RuralHolidayController(ILogger<RuralHolidayController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RuralHolidayOne() 
        {
            return View();
        }
        public IActionResult RuralHolidayTwo()
        {
            return View();
        }
        public IActionResult RuralHolidayThree()
        {
            return View();
        }
        public IActionResult RuralHolidayFour()
        {
            return View();
        }
        public IActionResult RuralHolidayFive()
        {
            return View();
        }
        public IActionResult RuralHolidaySix()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult InformationOfCompany()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
