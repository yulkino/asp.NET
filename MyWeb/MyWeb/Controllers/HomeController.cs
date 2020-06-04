using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWeb.Models;

namespace MyWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult FirstSite()
        {
            ViewData["randomStrArr"] = new string[] { "я календарь", "я цветок", "я каарта", "я рюкзак", "я КирсановаАА", "я отчислен", "непосредственно я" };
            return View();
        }

        public IActionResult SecondSite()
        {
            return View();
        }

        public bool Check(string piece, string from0, string to0)
        {
            return ChessLogic.Check(piece, from0, to0);
        }

        public IActionResult Index()
        {
            return View();
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

        public IActionResult Privacy()
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
