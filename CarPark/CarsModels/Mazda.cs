using SettingsLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    internal class Mazda : ICar
    {
        public string Mark { get; set; } = "MAZDA";
        public int Mileage { get; set; }
        public int Cost { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime YearManufacture { get; set; }
        public int VolumeFuel { get; set; } = default;

        public Mazda()
        {
            Model = Settings.SetName("car's model").ToUpper();
            YearManufacture = Settings.SetYearOfCarManufacture();
            Mileage = Settings.SetMileage();
            Cost = Settings.SetCarCost();
            RegistrationNumber = Settings.SetRegistrationNumber();
            VolumeFuel = Settings.SetVolumeFuel();
        }
    }
}
