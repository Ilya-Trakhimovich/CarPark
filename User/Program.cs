using System;
using System.Threading;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(1000);
            user.Added += Display;
            user.Add(100);
        }

        public static void Display(object sender, UserEventArgs e)
        {
            Console.WriteLine(e.MEssage);
        }
    }
}
