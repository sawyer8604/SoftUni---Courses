using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Models.Interfaces
{
    public interface IFood
    {
        public string Type { get;}
        public int Quantity { get; }
    }
}
