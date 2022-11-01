namespace CourseApp.Controllers;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Greetings = DateTime.Now.Hour > 12 ? "Good Days" : "Good Morning";
        ViewBag.User = "Deniz";
        return View();
    }
    public IActionResult About()
    {
        return View();
    }
}
