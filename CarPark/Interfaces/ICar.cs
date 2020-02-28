using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    public interface ICar
    {
        string Mark { get; set; }
        string Model { get; set; }
        int Mileage { get; set; }
        double Cost { get; set; }
        string RegistrationNumber { get; set; }

        void Display()
        {
            Console.WriteLine(
                $"Mark: {Mark}\n" +
                $"Model: {Model}\n" +
                $"Registration number: {RegistrationNumber}\n" +
                $"Mileage: {Mileage} km,\n" +
                $"Cost: {Cost}$");
        }
    }
}
