using System;

namespace Level3_OOPs_Advanced
{
    public class Program123_ThrowingExceptions
    {
        public static void Run()
        {
            try
            {
                Withdraw(1500, 1000);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Withdraw(decimal amount, decimal balance)
        {
            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient balance.");
            }

            Console.WriteLine("Withdrawal successful.");
        }
    }
}
