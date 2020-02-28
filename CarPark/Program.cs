using System;
using DocumentFormat.OpenXml.Office.CustomUI;
using SettingsLib;
using SettingsLib.Menu;

namespace CarPark
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarPark carPark = new CarPark();
            Menu<CarPark> menu = new Menu<CarPark>();
            bool flag = true;

            while (flag)
            {
                int choice = menu.ShowMenu(carPark);
                var tempChoice = (MenuAction)choice;

                switch (tempChoice)
                {
                    case MenuAction.AddCar:
                        {
                            break;
                        }
                    case MenuAction.SellCar:
                        { 
                            break;
                        }
                    case MenuAction.GetInfoOfCar:
                        {
                            break;
                        }
                    case MenuAction.GetInfoOfPark:
                        {
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
    }
}
