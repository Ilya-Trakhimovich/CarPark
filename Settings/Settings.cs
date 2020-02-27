using System;

namespace SettingsLib
{
    public static class Settings
    {
        public static string SetName()
        {
            string name = default;
            bool flag = true;

            while (flag)
            {
                Console.Write("Enter name: ");

                name = Console.ReadLine();
                bool isCorrectName = string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name);

                if (!isCorrectName)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Error. Name can't be null or empty.\n");
                    Console.ReadKey();
                }
            }

            return name;
        }

        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
