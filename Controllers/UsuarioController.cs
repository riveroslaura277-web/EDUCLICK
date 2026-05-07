using Microsoft.AspNetCore.Mvc;

namespace EDUCLICK.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Inicio()
        {
            return View();
        }
    }
}
