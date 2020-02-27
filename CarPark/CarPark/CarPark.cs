using System.Collections.Generic;
using SettingsLib;
using System;

namespace CarPark
{
    internal class CarPark
    {
        public string Name { get; private set; }

        public CarPark()
        {
            Name = SettingsLib.Settings.SetName();
            listOfCars = new List<ICar>();
        }

        public void AddCar(CarCreator car)
        {
            listOfCars.Add(car.FactoryMethod());
        }

        public void GetInfoOfPark()
        {
            if (listOfCars.Count == 0)
            {
                SettingsLib.Settings.ShowMessage($"The park {this.Name} is empty.\n");
            }
            else
            {
                SettingsLib.Settings.ShowMessage($"The park {this.Name} contains {this.listOfCars.Count} cars.\n");
            }

        }

        private readonly List<ICar> listOfCars;
    }
}
