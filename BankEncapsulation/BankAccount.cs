using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    class BankAccount
    {
        private double balance = 0;

        public double Balance { set { balance = value; } }

        public double Deposit(double deposit)
        {
            balance += deposit;
            return balance;
        }

        public void GetBalance()
        {
            Console.WriteLine(balance);
        }
    }
}
