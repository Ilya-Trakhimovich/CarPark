﻿using System;
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
            var menu = new MainMenu();
            bool flag = true;

            while (flag)
            {
                string carparkName = carPark.Name;
                int choice = menu.ShowMenu(carparkName);
                var tempChoice = (MenuAction)choice;

                switch (tempChoice)
                {
                    case MenuAction.AddCar:
                        {                            
                            carPark.AddCar();
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
