using System;

namespace Level3_OOPs_Advanced
{
    public class Program110_Encapsulation
    {
        public static void Run()
        {
            BankAccount account = new BankAccount();
            account.Deposit(5000);
            Console.WriteLine($"Current balance: {account.GetBalance()}");
        }

        private class BankAccount
        {
            private decimal balance;

            public void Deposit(decimal amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                }
            }

            public decimal GetBalance() => balance;
        }
    }
}
