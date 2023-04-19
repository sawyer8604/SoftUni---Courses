using Entity_Relations.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Relations.ModelBuilding
{
    public class EmployeeConfoguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder               
               .ToTable("People", "company")
               .Property(x => x.StartWorkDate)
               .HasColumnName("StartedOn");
        }
    }
}
