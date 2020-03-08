using System;
using System.Collections.Generic;
using System.Text;
using SettingsLib;

namespace User
{
    class User
    {

        public event UserHandler Added;
        public string Name { get; private set; }
        public int Money { get; set; }
        public User(int money)
        {
            Money = money;
        }

        private void CallEvent(UserEventArgs e, UserHandler handler)
        {
            if (e != null)
                handler?.Invoke(this, e);
        }

        public void OnAdded(UserEventArgs e)
        {
            CallEvent(e, Added);
        }

        public void Add(int sum)
        {
            Money += sum;
            OnAdded(new UserEventArgs($"Added {sum}", sum));
        }

    }

}
