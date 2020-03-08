using System;
using System.Collections.Generic;
using System.Text;

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
            foreach (var e in log)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}
