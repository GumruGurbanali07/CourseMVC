using CourseApp.Areas.Admin.Models.CourseCategoryDTOs;
using CourseApp.Context;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseCategoryController : Controller
    {
        private readonly AppDbContext _context;
        public CourseCategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.CourseCategories.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCourseCategory()
        {


            return View();
        }

        [HttpPost]
        public IActionResult CreateCourseCategory(CreateCourseCategoryDTO courseCategoryDto)
        {
            if (ModelState.IsValid)
            {
                CourseCategory courseCategory = new CourseCategory();
                courseCategory.CourseCategoryName = courseCategoryDto.CourseCategoryName;
                courseCategory.IsActive = false;
                _context.CourseCategories.Add(courseCategory);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(courseCategoryDto);
        }

        [HttpGet]
        public IActionResult UpdateCourseCategory(int id)
        {
            var courseCategoryValue = _context.CourseCategories.Find(id);
            var getCourseCategory = new UpdateCourseCategoryDTO
            {

                CourseCategoryName = courseCategoryValue.CourseCategoryName,
                IsActive = courseCategoryValue.IsActive,
                CourseCategoryId = courseCategoryValue.CourseCategoryId,

            };

            return View(getCourseCategory);
        }
        [HttpPost]
        public IActionResult UpdateCourseCategory(UpdateCourseCategoryDTO updateCourseCategoryDTO)
        {
            if (ModelState.IsValid)
            {
                var values = _context.CourseCategories.Find(updateCourseCategoryDTO.CourseCategoryId);
                values.CourseCategoryName = updateCourseCategoryDTO.CourseCategoryName;
                values.CourseCategoryId = updateCourseCategoryDTO.CourseCategoryId;
                values.IsActive = values.IsActive;

                _context.CourseCategories.Update(values);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(updateCourseCategoryDTO);
        }

        public IActionResult DeleteCourseCategory(int id)
        {
            var values = _context.CourseCategories.Find(id);
            _context.CourseCategories.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeStatusToTrue(int id)
        {
            var values = _context.CourseCategories.Find(id);
            values.IsActive = true;
            _context.CourseCategories.Update(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToFalse(int id)
        {
            var values = _context.CourseCategories.Find(id);
            values.IsActive = false;
            _context.CourseCategories.Update(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}
