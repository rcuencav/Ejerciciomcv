using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aplicacionmvc.Models;

namespace aplicacionmvc.Controllers
{
    public class HomeController : Controller
    {

        public Contact contact { set; get; }
        public IActionResult Index()
        {
            return View();
        }

        
       
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

      
        public IActionResult RegisterContact()
        {

            ViewData["Message"] = "Exitoso";

            return View();
        }
        [HttpPost]
        public IActionResult RegisterContact(Contact C)
        {

            ViewData["Message"] = "Exitoso";

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
