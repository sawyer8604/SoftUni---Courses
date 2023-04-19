using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Relations.Models
{
    public class Department
    {
        public Department()
        {
            this.Employees = new HashSet<Employee>();
        }
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; } 
    }
}
