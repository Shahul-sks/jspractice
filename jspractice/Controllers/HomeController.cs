using jspractice.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace jspractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
            //return new EmptyResult();
            //return Content("Custom View");
        }

        public IActionResult Sample()
        {
            return View();          
        }


        public string Name()
        {
            return "Shahul Singh";
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
