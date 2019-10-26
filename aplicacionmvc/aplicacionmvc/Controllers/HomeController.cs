using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aplicacionmvc.Models;
using System.Net;

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
            System.Net.HttpWebRequest request = WebRequest.Create("https://localhost:44380/api/values") as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded"; 

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            System.IO.StreamReader reader = new System.IO.StreamReader(response.GetResponseStream());
            string resp = reader.ReadToEnd();

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
