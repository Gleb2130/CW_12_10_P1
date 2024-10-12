using CW_12_10_P1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CW_12_10_P1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Play()
        {
            return View();
        }
    }
}