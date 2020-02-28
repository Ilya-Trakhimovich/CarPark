using System;

namespace SettingsLib
{
    public static class Settings
    {
        public static string SetName(string value)
        {
            string name = default;
            bool flag = true;

            while (flag)
            {
                Console.Write($"Enter {value}: ");

                name = Console.ReadLine();
                bool isCorrectName = string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name);

                if (!isCorrectName)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine($"Error. {value} can't be null or empty.\n");
                    Console.ReadKey();
                }
            }

            return name;
        }

        public static string InputRegistrationNumber()
        {        
            Console.Write("Enter registration number: ");
            string regNumbers = Console.ReadLine();
            return regNumbers;
        }

        public static string SetRegistrationNumber()
        {                     
            string registrationNumber = GetRegistrationNumbers();
            registrationNumber += " ";
            registrationNumber += GetRegistrationLetters();
            registrationNumber += "-";
            registrationNumber += GetRegistrationRegion();            

            return registrationNumber;
        }

        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        private static string GetRegistrationNumbers()
        {
            string regNumbers = default;

            for (var i = 0; i < 4; i++)
            {
                regNumbers += _rnd.Next(0, 10).ToString();
            }

            return regNumbers;
        }

        private static string GetRegistrationLetters()
        {
            string letters = "etiopahkxcbm".ToUpper();
            string regLetters = default;

            for (var i = 0; i < 2; i++)
            {
                int letter = _rnd.Next(0, letters.Length);
                regLetters += letters[letter];
            }

            return regLetters;
        }

        private static string GetRegistrationRegion()
        {
            string regRegion = default;

            for (var i = 0; i < 1; i++)
            {
                regRegion += _rnd.Next(1, 8).ToString();
            }

            return regRegion;
        }

        private static readonly Random _rnd = new Random();
    }
}
