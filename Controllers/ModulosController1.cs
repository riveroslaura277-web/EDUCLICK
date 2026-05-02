using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EduClickWeb.Controllers
{
    public class ModulosController : Controller
    {
        // Muestra la lista de mundos o materias disponibles
        public IActionResult Index()
        {
            var mundos = new List<string>
            {
                "Planeta Matemáticas",
                "Galaxia de las Letras",
                "Nebulosa de Ciencias"
            };

            return View(mundos);
        }

        // Detalle de un módulo específico
        public IActionResult VerDestino(string nombreMundo)
        {
            ViewBag.Mundo = nombreMundo;
            return View();
        }
    }
}
