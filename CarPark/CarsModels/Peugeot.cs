using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    internal class Peugeot : ICar
    {
        public string Mark { get; set; } = "PEUGEOT";
        public int Mileage { get; set; }
        public int Cost { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime YearManufacture { get; set; }
    }
}
