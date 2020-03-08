using System;
using System.Collections.Generic;
using System.Text;

namespace User
{
    public delegate void UserHandler(object sender, UserEventArgs e);
    public class UserEventArgs
    {
        public int Money { get; set; }
        public string MEssage { get; set; }

        public UserEventArgs(string mex, int mon)
        {
            MEssage = mex;
            Money = mon;
        }

    }
}
