using System.Collections.Generic;
using SettingsLib;
using System;
using System.Linq;

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

        public void AddCar()
        {
            ICar car = CreateCar();

            if (car != null)
            {
                _listOfCars.Add(car);
            }
        }

        public void GetInfoOfPark()
        {
            if (CheckParkForEmptiness())
            {
                return;
            }
            else
            {
                Settings.ShowMessage(
                    $"The park {this.Name} contains:\n" +
                    $"  BMW - {this._listOfCars.Count(car => car?.Mark == "BMW")} cars\n" +
                    $"  AUDI - {this._listOfCars.Count(car => car?.Mark == "AUDI")} cars\n" +
                    $"  Mazda - {this._listOfCars.Count(car => car?.Mark == "MAZDA")} cars");
            }
        }

        public void ShowCarsList()
        {
            foreach (var car in _listOfCars)
            {
                if (car != null)
                {
                    Console.WriteLine($"{car.Mark} {car.Model} || {car.RegistrationNumber} || {car?.Cost}$/min || {car.VolumeFuel}L");
                }
            }

            Console.WriteLine();
        }

        public ICar GetInfoCar()
        {
            if (CheckParkForEmptiness())
            {
                return null;
            }
            else
            {
                ICar car = GetCarByRegistrationNumber();

                if (car != null)
                {
                    car.DisplayInfo();
                }
            }

            return null;
        }

        private ICar CreateCar()
        {
            string mark = Settings.SetName("car's mark").ToUpper();
            CarCreator1 creator;

            switch (mark)
            {
                case "BMW":
                    {
                        creator = new CreateBMW();
                        break;
                    }
                case "AUDI":
                    {
                        creator = new CreateAudi();
                        break;
                    }
                case "MAZDA":
                    {
                        creator = new CreateMazda();
                        break;
                    }
                default:
                    {
                        creator = default;

                        Settings.ShowMessage("Error. List of car's marks: Audi, BMW, Mazda, Peugeot.\n");
                        break;
                    }
            }

            return creator?.FactoryMethod();
        }

        private bool CheckParkForEmptiness()
        {
            if (_listOfCars.Count == 0)
            {
                Settings.ShowMessage($"The park {this?.Name} is empty.");
                return true;
            }

            return false;
        }

        private ICar GetCarByRegistrationNumber()
        {
            ICar car = null;
            string registrationNumber = Settings.SetName("registration number").ToUpper();

            for (var i = 0; i < _listOfCars.Count; i++)
            {
                if (_listOfCars[i].RegistrationNumber == registrationNumber)
                {
                    car = _listOfCars[i];
                    break;
                }
            }

            if (car == null)
            {
                Settings.ShowMessage("The park hasnt that car.\n");
            }

            return car;
        }

        private readonly List<ICar> _listOfCars;
    }
}
