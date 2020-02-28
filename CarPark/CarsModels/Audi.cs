using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    internal class Audi : ICar
    {
        public string Mark { get; set; } = "Audi";
        public int Mileage { get; set; }
        public double Cost { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }        
    }
}
