using System;
using System.Collections.Generic;
using System.Text;

namespace SettingsLib
{
    public class Menu<T> where T: class
    {
        private const string _arrow = "--> ";
        private readonly string[] _menu =
            {
                "  Add car",
                "  Sell car",
                "  Display information about car",
                "  Display information about park",
                "  Exit."
            };

        private void Welcome(T tempItem)
        { 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\t\t***** {tempItem.ToString()} ***** \n\n");
            Console.ResetColor();
        }

        private void MoveArrow(int moveChoice, T tempItem)
        {
            Console.Clear();
            Welcome(tempItem);

            for (var i = 0; i < _menu.Length; i++)
            {
                if (i == moveChoice)
                {
                    Console.Write(_arrow);
                }

                Console.WriteLine(_menu[i]);
            }
        }

        public int ShowMenu(T tempItem)
        {
            int choice = 0;
            Console.CursorVisible = false;

            while (true)
            {
                MoveArrow(choice, tempItem);

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
    }
}
