using Microsoft.AspNetCore.Mvc;
using ModelBindingDemo.Models;

namespace YourProjectName.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student student)
        {
            return View("Result", student);
        }
    }
}