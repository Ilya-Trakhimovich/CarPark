using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    internal interface ICar
    {
        int Mileage { get; set; }
        double Cost { get; set; }
        string Model { get; set; }
    }
}
