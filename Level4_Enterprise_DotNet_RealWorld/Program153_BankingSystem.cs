using System;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program153_BankingSystem
    {
        public static void Run()
        {
            BankAccount account = new BankAccount("SB101", 5000m);
            account.Deposit(1000m);
            account.Withdraw(1200m);
            Console.WriteLine($"Account: {account.AccountNumber}, Balance: {account.Balance:C}");
        }

        private class BankAccount
        {
            public BankAccount(string accountNumber, decimal balance)
            {
                AccountNumber = accountNumber;
                Balance = balance;
            }

            public string AccountNumber { get; }
            public decimal Balance { get; private set; }

            public void Deposit(decimal amount) => Balance += amount;

            public void Withdraw(decimal amount)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                }
            }
        }
    }
}
