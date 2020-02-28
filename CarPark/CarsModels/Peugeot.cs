using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    internal class Peugeot : ICar
    {
        public string Mark { get; set; } = "Peugeot";
        public int Mileage { get; set; }
        public double Cost { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
    }
}
