using System.Collections.Generic;
using SettingsLib;
using System;
using System.Linq;

namespace CarPark
{
    public class CarPark
    {
        public event CarParkHandler Added;
        public event CarParkHandler Sold;
        public string Name { get; private set; }

        public CarPark()
        {
            Name = Settings.SetName("name of park");
            _listOfCars = new List<ICar>();
        }

        public void OnAdedd(CarParkEventArgs e)
        {
            CallEvent(e, Added);
        }

        public void OnSold(CarParkEventArgs e)
        {
            CallEvent(e, Sold);
        }

        public void AddCar()
        {
            ICar car = CreateCar();

            if (car != null)
            {
                _listOfCars.Add(car);
                OnAdedd(new CarParkEventArgs($"The car {car?.Mark} {car?.Model} {car?.RegistrationNumber} added."));
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
                    $"The park {Name} contains:\n" +
                    $"  BMW - {_listOfCars?.Count(car => car?.Mark == "BMW")} cars\n" +
                    $"  AUDI - {_listOfCars?.Count(car => car?.Mark == "AUDI")} cars\n" +
                    $"  Mazda - {_listOfCars?.Count(car => car?.Mark == "MAZDA")} cars");
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

        public void SellCar()
        {
            bool isEmpty = CheckParkForEmptiness();

            if(!isEmpty)
            {
                ICar car = GetCarByRegistrationNumber();

                if (car != null)
                {
                    for (var i = 0; i < _listOfCars.Count; i++)
                    {
                        if (_listOfCars[i] == car)
                        {
                            _listOfCars[i] = null;
                            Settings.ShowMessage("The car is sold.");
                            OnSold(new CarParkEventArgs($"The car {car?.Mark} {car?.Model} {car?.RegistrationNumber} sold."));
                        }
                    }
                }
            }

            _listOfCars = RemoveNullCar();
        }

        private void CallEvent(CarParkEventArgs e, CarParkHandler handler)
        {
            if (e != null)
            {
                handler?.Invoke(this, e);
            }
        }

        private List<ICar> RemoveNullCar()
        {
            var tempCarList = new List<ICar>();

            for (var i = 0; i < _listOfCars.Count; i++)
            {
                if (_listOfCars[i] != null)
                {
                    tempCarList.Add(_listOfCars[i]); 
                }
            }

            return tempCarList;
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
                if (_listOfCars[i]?.RegistrationNumber == registrationNumber)
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

        private List<ICar> _listOfCars;
    }
}
