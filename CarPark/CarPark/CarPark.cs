using System.Collections.Generic;
using SettingsLib;
using System;

namespace CarPark
{
    public class CarPark
    {
        public string Name { get; private set; }

        public CarPark()
        {
            Name = Settings.SetName("name of park");
            _listOfCars = new List<ICar>();
        }

        public void AddCar(ICar car)
        {
            _listOfCars.Add(car);
        }

        public void GetInfoOfPark()
        {
            if (_listOfCars.Count == 0)
            {
                Settings.ShowMessage($"The park {this.Name} is empty.\n");
            }
            else
            {
                Settings.ShowMessage($"The park {this.Name} contains {this._listOfCars.Count} cars.\n");
            }
        }

        public void SellCar()
        {
            bool flag = true;
            string model;
            string registrationNumber;

            while (flag)
            {
                model = Settings.SetName("model");
                registrationNumber = Settings.InputRegistrationNumber();

                for (var i = 0; i < _listOfCars.Count; i++)
                {
                    if (_listOfCars[i].Model == model & _listOfCars[i].RegistrationNumber == registrationNumber)
                    {
                        _listOfCars[i] = null;
                        Console.WriteLine("The car is sold.");
                    }
                }
            }
        }

        private readonly List<ICar> _listOfCars;
    }
}
