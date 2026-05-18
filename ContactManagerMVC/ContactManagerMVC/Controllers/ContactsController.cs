using ContactManagerMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactManagerMVC.Controllers
{
    public class ContactsController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ContactsController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Get Contactos
        [HttpGet]
        public async Task<IActionResult> Index()  // ✅ Agregar "async Task"
        {
            var contacts = await _context.Contacts.ToListAsync();
            return View(contacts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
