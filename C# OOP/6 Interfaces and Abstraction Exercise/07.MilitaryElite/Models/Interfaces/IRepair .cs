using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Models.Interfaces
{
    public interface IRepair
    {
        public string PartName { get; set; }
        public int WorkedHours { get; set; }
    }
}
