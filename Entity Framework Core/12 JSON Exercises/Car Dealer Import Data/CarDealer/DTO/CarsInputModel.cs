using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.DTO
{
    public class CarsInputModel
    {
        public CarsInputModel()
        {
            PartsId = new List<int>();
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int TravelledDistance { get; set; }
        public List<int> PartsId { get; set; }

    }
}
