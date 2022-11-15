namespace CourseApp.Controllers;
using CourseApp.Models;
using CourseApp.ViewModels;
using Microsoft.AspNetCore.Mvc;


public class CourseController : Controller
{
    public IActionResult Index()
    {
        var kurs = new Course()
        {
            Name = "Web Programming",
            Description = "Asp.net core mvc",
            IsOpened = true
        };
        var ogr = new List<student>()
        {
            new student(){Name="Ali"},
            new student(){Name="Veli"},
            new student(){Name="Ayşe"},
            new student(){Name="Fatma"},
            new student(){Name="Ahmet"}

        };

        var viewmodel = new CourseStudentViewModel();
        viewmodel.crs = kurs;
        viewmodel.std = ogr;



        // ViewData["Course"] = kurs;
        // ViewBag.course = kurs;
        // ViewBag.count = 10;
        return View(viewmodel);
    }

    //Examples for returning type

    /*public IActionResult Index1()
    {
        return RedirectToAction("List");
    }
    public IActionResult Index2()
    {
        return NotFound();
    }
    public IActionResult Index3()
    {
        return Unauthorized();

    }
    public IActionResult Index4()
    {
        return Redirect("Index");
    }
    public IActionResult Index5()
    {
        return Content("Hello World");
    }*/
    //----------------------------------------------

    public IActionResult List()
    {
        var s = Repository.studs.Where(i => i.Confirm == true);
        return View(s);
    }
    public IActionResult Details(int? id, string? sortby)
    {
        // var course = new Course();
        // course.Name = "ASP.Net Core MVC";
        // course.Description = "MVC Fundamentals";
        // course.IsOpened = true;
        // return View(course);

        if (!id.HasValue)
        {
            id = 1;
        }
        if (string.IsNullOrWhiteSpace(sortby))
        {
            sortby = "name";
        }
        {
            sortby = "name";
        }

        return Content("id: " + id + " sortby: " + sortby);

    }
    public IActionResult Thanks(student std)
    {
        // ViewBag.stdName = TempData["stdName"];
        // ViewBag.stdConfirm = TempData["stdConfirm"];
        return View(std);
    }

    [HttpGet]
    public IActionResult Apply()
    { //for only view Apply.cshtml
        return View();
    }
    [HttpPost]
    public IActionResult Apply(student std)
    { //for save form data into server
        if (ModelState.IsValid)
        {
            //save data in repository
            Repository.AddStudent(std);

            //While using this tempdata we dont send directly std object. 
            //That's mean std's datas will not be visible on link bar.
            //We need to change Thanks.cshtml also.
            // TempData["stdName"] = std.Name;
            // TempData["stdConfirm"] = std.Confirm;
            return RedirectToAction("Thanks", std); //redirect Thanks.cshtml for listing data
        }
        else
        {
            return View(std);
        }

    }
    public IActionResult ByReleased(int year, int month)
    {
        return Content("year: " + year + " month: " + month);
    }
}
