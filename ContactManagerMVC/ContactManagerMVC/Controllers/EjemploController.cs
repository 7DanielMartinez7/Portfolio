using Microsoft.AspNetCore.Mvc;

namespace ContactManagerMVC.Controllers
{
    public class EjemploController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hola");
        }
        public IActionResult Detalle(int id)
        {
            return Content($"Detalle recibido con ID {id}");
        }
    }
}
