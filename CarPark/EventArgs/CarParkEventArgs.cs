using CarPark;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    public delegate void CarParkHandler(object ender, CarParkEventArgs e);

    public class CarParkEventArgs : IMessage
    {
        public string Message { get; set; }

        public CarParkEventArgs(string message)
        {
            Message = message;
        }
    }
}
