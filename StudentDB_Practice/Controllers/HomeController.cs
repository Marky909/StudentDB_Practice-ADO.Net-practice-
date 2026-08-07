using Microsoft.AspNetCore.Mvc;

namespace StudentDB_Practice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

      
    }
}
