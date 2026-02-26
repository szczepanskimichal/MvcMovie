using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    public IActionResult Index()
    {
        ViewData["MovieTitle"] = "Ghostbusters";
        ViewData["NumTimes"] = 3;
        return View();
    }
    public IActionResult Welcome(string name="MICHAL", int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}