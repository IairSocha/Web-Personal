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

    public IActionResult Index() => View();
    public IActionResult form() => View();
    public IActionResult huesca() => View();
    public IActionResult teruel() => View();
    public IActionResult thankyou() => View();
    public IActionResult zaragoza() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
