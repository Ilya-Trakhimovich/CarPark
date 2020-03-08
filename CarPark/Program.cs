using System;
using System.Threading;
using CarPark.EventArgs;
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

            bool flag = true;

            while (flag)
            {
                string carparkName = _carPark.Name;
                int choice = _menu.ShowMenu(carparkName, _carPark.ShowCarsList);
                var tempChoice = (MenuAction)choice;

                switch (tempChoice)
                {
                    case MenuAction.AddCar:
                        {
                            _carPark.AddCar();
                            break;
                        }
                    case MenuAction.SellCar:
                        {
                            _carPark.SellCar();
                            break;
                        }
                    case MenuAction.GetInfoOfCar:
                        {
                            _carPark.GetInfoCar();
                            break;
                        }
                    case MenuAction.GetInfoOfPark:
                        {
                            _carPark.GetInfoOfPark();
                            break;
                        }
                    case MenuAction.DisplayEventLog:
                        {
                            EventLog.DisplayEventLog();
                            break;
                        }
                    case MenuAction.Exit:
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
    }
}
