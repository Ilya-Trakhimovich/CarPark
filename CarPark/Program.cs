using System;
using System.Threading;
using CarPark.EventArgs;
using CarPark.Lease;
using DocumentFormat.OpenXml.Office.CustomUI;
using SettingsLib;
using SettingsLib.Menu;

namespace CarPark
{
    public class Program
    {

        static void Main(string[] args)
        {
            CreateCarMenu();
        }

        private static void CreateCarMenu()
        {
            _carPark.Added += GetMessageForLog;
            _carPark.Sold += GetMessageForLog;
            _lease.StartedMove += GetMessageForLog;

            bool flag = true;

            while (flag)
            {
                string carparkName = _carPark.Name;
                int choice = _menu.ShowMenu(carparkName, _carPark.ShowCarsList);
                var tempChoice = (enumMenuAction)choice;

                switch (tempChoice)
                {
                    case enumMenuAction.AddCar:
                        {
                            _carPark.AddCar();
                            break;
                        }
                    case enumMenuAction.SellCar:
                        {
                            _carPark.SellCar();
                            break;
                        }
                    case enumMenuAction.GetInfoOfCar:
                        {
                            _carPark.GetInfoCar();
                            break;
                        }
                    case enumMenuAction.GetInfoOfPark:
                        {
                            _carPark.GetInfoOfPark();
                            break;
                        }
                    case enumMenuAction.DisplayEventLog:
                        {
                            EventLog.DisplayEventLog();
                            break;
                        }
                    case enumMenuAction.StartMoving:
                        {
                            _lease.StartMoving(_carPark);
                            break;
                        }
                    case enumMenuAction.Exit:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
        }

        private static void GetMessageForLog(object sender, CarParkEventArgs e)
        {
            string infoEvent = DateTime.Now.ToString() + " " + e.Message;
            EventLog.log.Add(infoEvent);
        }

        private static readonly CarPark _carPark = new CarPark();
        private static readonly MainMenu _menu = new MainMenu();
        private static readonly LeaseFunction _lease = new LeaseFunction();
    }
}
