using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class SlidDbContext : DbContext
    {
        public SlidDbContext()
        {
            
        }
        public SlidDbContext(DbContextOptions dbContextOptions)
            :base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>().Property(x => x.Content).IsUnicode(true);
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Slido;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;User Instance=False");
            }
        }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Questions> Questions { get; set; }

    }
}
