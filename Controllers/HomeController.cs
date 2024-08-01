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
    public IActionResult huesca(){
        ViewBag.LugaresTuristicos = Datos.LugaresTuristicosHuesca;
        return View();
    }
    public IActionResult teruel(){
        ViewBag.LugaresTuristicos = Datos.LugaresTuristicosTeruel;
        return View();
    }
    public IActionResult zaragoza(){
        ViewBag.LugaresTuristicos = Datos.LugaresTuristicosZaragoza;
        return View();
    }
    public IActionResult thankyou() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
