using Microsoft.AspNetCore.Mvc;

namespace jspractice.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Emp()
        {
            return View();
        }

        public string Details(int id)
        {
            string d;
            if (id == 1)
            {
                return d="First";
            }
            else
            {
                return d = "Last";
            }
        }

    }
}
