using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DependencyInjection_Assi.Models;

namespace DependencyInjection_Assi.Controllers
{
    public class HomeController : Controller
    {
        private IGreet _igreet;
        public HomeController(IGreet igreet)
        {
            _igreet = igreet;
        }
        public string Index()
        {
            return _igreet.display();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
