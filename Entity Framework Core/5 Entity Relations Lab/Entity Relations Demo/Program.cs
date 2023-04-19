using Entity_Relations.Models;
using System;

namespace Entity_Relations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new ApplicationDbContext();
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            var departament = new Department { Name = "HR" };

            for (int i = 0; i < 10; i++)
            {
                db.Employees.Add(new Employee
                {
                    FirstName = "Mus",
                    LastName = "Apt",
                    StartWorkDate = DateTime.Now,
                    Salary = 10000 + i,
                    Department = departament
                });
            }
            
            db.SaveChanges();
        }
    }
}
