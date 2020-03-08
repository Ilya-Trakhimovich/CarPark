using System;
using System.Collections.Generic;
using System.Text;
using SettingsLib;

namespace CarPark.EventArgs
{
    public static class EventLog
    {
        public static List<string> log;

        static EventLog()
        {
            log = new List<string>();
        }

        public static void DisplayEventLog()
        {
            if (log.Count == 0)
            {
                Settings.ShowMessage("List is empty");
                return;
            }
            
            foreach (var e in log)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}
