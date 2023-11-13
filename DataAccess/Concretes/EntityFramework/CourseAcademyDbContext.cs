using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class CourseAcademyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=CourseAcademy;Trusted_Connection=true;TrustServerCertificate=True;");
        }
        public DbSet<Course> Courses{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Instructor> Instructors{ get; set; }
        public DbSet<CourseInstructor> CoursesInstructors{ get; set; }
    }
}
