using CourseApp.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CourseApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseSubscribeController : Controller
    {
        private readonly AppDbContext _context;
        public CourseSubscribeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.CourseSubcribes.Include(x => x.Course).ToList();
            return View(values);
        }
        public IActionResult StudentListByCourse(int id)
        {
            return View();
        }
    }
}
