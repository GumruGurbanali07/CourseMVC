using CourseApp.Context;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
