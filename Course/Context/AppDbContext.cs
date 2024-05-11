using CourseApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseApp.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<Courses> Coursess { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Testimonial> Testimonials { get; set;}
        public DbSet<CourseSubcribe> CourseSubcribes { get; set; }
    }
}
