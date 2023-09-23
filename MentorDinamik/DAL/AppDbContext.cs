using MentorDinamik.Entities;
using Microsoft.EntityFrameworkCore;

namespace MentorDinamik.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Feature> Features { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<WhyUs> WhyUss { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutImage> AboutImages { get; set; }
    }
}
