using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;

namespace P01_StudentSystem.Data
{
    public class StudentSystemDbContext : DbContext
    {
        public StudentSystemDbContext()
        {
            
        }

        public StudentSystemDbContext(DbContextOptions options)
            : base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Student_System;Integrated Security=true;;Encrypt=True;TrustServerCertificate=True;User Instance=False");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity.HasKey(pk => new { pk.StudentId, pk.CourseId });
            });
        }



    }
}
