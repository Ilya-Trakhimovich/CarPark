using System;
using System.Collections.Generic;
using System.Text;

namespace SettingsLib
{
    public class MainMenu
    {           
        public int ShowMenu(string name)
        {
            int choice = 0;
            Console.CursorVisible = false;

            while (true)
            {
                MoveArrow(choice, name);

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (choice != 0)
                            {
                                --choice;
                            }

                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (choice != _menu.Length - 1)
                            {
                                ++choice;
                            }

                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            return choice;
                        }
                }
            }
        }
        private void MoveArrow(int moveChoice, string name)
        {
            Console.Clear();
            DisplayName(name);

            for (var i = 0; i < _menu.Length; i++)
            {
                if (i == moveChoice)
                {
                    Console.Write(_arrow);
                }

                Console.WriteLine(_menu[i]);
            }
        }

        private void DisplayName(string name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\t\t***** {name} ***** \n\n");
            Console.ResetColor();
        }

        private const string _arrow = "--> ";
        private readonly string[] _menu =
            {
                "  Add car",
                "  Sell car",
                "  Display information about car",
                "  Display information about park",
                "  Exit."
            };
    }
}
