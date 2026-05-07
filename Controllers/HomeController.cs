using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EDUCLICK.Models;

namespace EDUCLICK.Controllers;

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

    public IActionResult Roles ()
    {
        return View("~/Views/roless/fondoRoles.cshtml");
    }
    public IActionResult Docente()
    {
        return View("~/Views/vistaRoles/Docente.cshtml");
    }
    public IActionResult Acudiente ()
    {
        return View("~/Views/vistaRoles/Acudiente.cshtml");
    }

    public IActionResult Estudiante()
    {
        return View("~/Views/vistaRoles/Estudiante.cshtml");
    }

    public IActionResult Rector ()
    {
        return View("~/Views/vistaRoles/Rctor.cshtml");
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
