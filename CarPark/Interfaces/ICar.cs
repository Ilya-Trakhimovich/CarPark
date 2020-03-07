using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    public interface ICar
    {
        string Mark { get; set; }
        string Model { get; set; }
        DateTime YearManufacture { get; set; }
        int Mileage { get; set; }
        int Cost { get; set; }
        string RegistrationNumber { get; set; }
        int VolumeFuel { get; set; }

        void DisplayInfo()
        {
            Console.WriteLine(
                $"\nMark: {Mark}\n" +
                $"Model: {Model}\n" +
                $"Year of manufacture: {YearManufacture.Year}\n" +
                $"Registration number: {RegistrationNumber}\n" +
                $"Mileage: {Mileage} km\n" +
                $"Cost: {Cost}$/min\n" +
                $"VolumeFuel: {VolumeFuel}L");
            Console.ReadKey();
        }
    }
}
