using Microsoft.AspNetCore.Mvc;

namespace Homework_26_05.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}