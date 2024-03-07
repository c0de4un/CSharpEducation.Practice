using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task29And30
{
    public class Account
    {
        private double _balance = 0.00;

        public Account()
        {
        }

        public Account AddMoney(double val)
        {
            _balance += Math.Abs(val);

            return this;
        }

        public Account TakeMoney(double val)
        {
            val = Math.Abs(val);
            _balance = Math.Max(0, val);

            return this;
        }

        public void ShowBalance()
        {
            System.Console.WriteLine($"Баланс: {_balance}");
        }
    }
}