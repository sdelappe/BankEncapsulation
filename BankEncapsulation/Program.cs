using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var accnt1 = new BankAccount();

            accnt1.Deposit(2549.77);

            accnt1.GetBalance();

        }
    }
}
