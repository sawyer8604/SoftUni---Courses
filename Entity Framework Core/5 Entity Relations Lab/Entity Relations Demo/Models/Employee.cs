using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Relations.Models
{
    public class Employee
    {
        public Employee()
        {
            this.ClubParticipations = new HashSet<EmployeeInClub>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? StartWorkDate { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; } // контрол върху DepartmentId
        public Department Department { get; set; }
        
        [ForeignKey("Adress")]
        public int? AddressId { get; set; }
        public Address Address { get; set; } // one to ne 

        public ICollection<EmployeeInClub> ClubParticipations { get; set; } // many to many
    }
}
