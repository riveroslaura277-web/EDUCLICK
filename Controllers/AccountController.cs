using Microsoft.AspNetCore.Mvc;

namespace EduClickWeb.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        public IActionResult Register(string nombre, string email, string password)
        {
            // Aquí iría la lógica para guardar al nuevo explorador en la base de datos
            if (ModelState.IsValid)
            {
                // Redirigir al perfil o al inicio después de registrarse
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}