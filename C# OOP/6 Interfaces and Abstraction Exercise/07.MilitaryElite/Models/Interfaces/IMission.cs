using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Models.Interfaces
{
    public interface IMission
    {
        public string CodeName { get; set; }
        public State Status { get; set; }
        
    }
}
