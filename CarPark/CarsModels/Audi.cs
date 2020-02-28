using System;
using System.Collections.Generic;
using System.Text;
using SettingsLib;

namespace CarPark
{
    internal class Audi : ICar
    {
        public string Mark { get; set; } = "AUDI";
        public int Mileage { get; set; }
        public int Cost { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime YearManufacture { get; set; }

        public Audi()
        {
            Model = Settings.SetName("car's model");
            YearManufacture = Settings.SetYearOfCarManufacture();
            Mileage = Settings.SetMileage();
            Cost = Settings.SetCarCost();            
            RegistrationNumber = Settings.SetRegistrationNumber();
        }
    }
}
