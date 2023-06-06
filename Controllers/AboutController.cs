using Homework_26_05.DAL;
using Homework_26_05.Migrations;
using Homework_26_05.ViewModels.About;
using Microsoft.AspNetCore.Mvc;

namespace Homework_26_05.Controllers;

public class AboutController : Controller
{
    private readonly AppDbContext _context;
    public AboutController (AppDbContext context)
    {
        _context = context;
    }
    
    public IActionResult Index()
    {
        var aims = _context.AimComponents.ToList();
        var model = new AboutIndexVM()
        {
            Aims = aims
        };
        return View(model);
    }
}