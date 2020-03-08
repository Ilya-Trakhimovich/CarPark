using System;
using System.Collections.Generic;
using System.Text;
using SettingsLib;

namespace CarPark.Lease
{
    internal class LeaseFunction
    {
        internal event CarParkHandler StartedMove;
        internal ICar StartMoving(CarPark carPark)
        {
            ICar car = null;

            if (carPark.GetCountCars())
            {
                car = carPark.GetCarByRegistrationNumber();

                if (car != null)
                {
                    Settings.ShowMessage($"The car is moving");
                    OnStartedMove(new CarParkEventArgs($"The car {car?.Mark} {car?.Model} {car?.RegistrationNumber} started moving."));
                }
            }
            else
            {
                Settings.ShowMessage("The park is empty");
            }

            return car;
        }

        public void OnStartedMove(CarParkEventArgs e)
        {
            CallEvent(e, StartedMove);
        }

        private void CallEvent(CarParkEventArgs e, CarParkHandler handler)
        {
            if (e != null)
            {
                handler?.Invoke(this, e);
            }
        }
    }
}
