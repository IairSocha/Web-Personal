using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_Personal.Models;

namespace Web_Personal.Controllers;

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
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult form()
    {
        return View();
    }
    public IActionResult huesca()
    {
        return View();
    }
    public IActionResult teruel()
    {
        return View();
    }
    public IActionResult thankyou()
    {
        return View();
    }
    public IActionResult zaragoza()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
