using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    internal class Peugeot : ICar
    {
        public string Name { get; set; }
        public int Mileage { get; set; }
        public double Cost { get; set; }
        public string Model { get; set; }
    }
}
