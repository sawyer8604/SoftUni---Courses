using Entity_Relations.ModelBuilding;
using Microsoft.EntityFrameworkCore;

namespace Entity_Relations.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Address> Adresses { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<EmployeeInClub> EmployeeInClubs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Entity_Relations;Integrated Security=true;;Encrypt=True;TrustServerCertificate=True;User Instance=False");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfoguration());

            modelBuilder.Entity<EmployeeInClub>()
                .HasKey(x => new {x.EmployeeId, x.ClubId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
