using CourseApp.Areas.Admin.Models.AdminDTOs;
using CourseApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CourseApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public AdminController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult CreateAdmin()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAdmin(CreateAdminDTO createAdminDTO)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    Name = createAdminDTO.Name,
                    Email = createAdminDTO.Email,
                    Surname = createAdminDTO.Surname,
                    Image = UploadFile(createAdminDTO.Image),
                    UserName = createAdminDTO.Username
                };
                var result = await _userManager.CreateAsync(appUser, createAdminDTO.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(appUser, "ADMIN");
                    return RedirectToAction("Index");
                }

            }
            return View(createAdminDTO);
        }

        public async Task<IActionResult> Index()
        {
            var values=await _userManager.Users.ToListAsync();
            return View(values);
        }
 

        public async Task<IActionResult> DeleteAdmin(string id)
        {
            var values= await  _userManager.FindByIdAsync(id);
            await _userManager.DeleteAsync(values);
            return RedirectToAction("Index");
        }

        private string UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return null;

            var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "wwwroot/ImagesFiles/AdminImagesFiles/",
                        file.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            return "/ImagesFiles/AdminImagesFiles/" + file.FileName;
        }
    }
}
