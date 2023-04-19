using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Relations.Models
{
    public class Club
    {
        public Club()
        {
            Employes = new HashSet<EmployeeInClub>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<EmployeeInClub> Employes { get; set; } // many to many
    }
}
