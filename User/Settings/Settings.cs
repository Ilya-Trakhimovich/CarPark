using System;
using System.Collections.Generic;
using System.Text;

namespace User
{
    static class Settings
    {
         public static int SetAmountMoney()
        {
            int minAmount = 50;
            int maxAmount = 100;
            int amountMoney = _rnd.Next(minAmount, maxAmount);

            return amountMoney;
        }

        private static readonly Random _rnd = new Random();
    }
}
