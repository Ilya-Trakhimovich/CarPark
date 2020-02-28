using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    internal class Mazda : ICar
    {
        public string Mark { get; set; } = "Mazda";
        public int Mileage { get; set; }
        public double Cost { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
    }
}
