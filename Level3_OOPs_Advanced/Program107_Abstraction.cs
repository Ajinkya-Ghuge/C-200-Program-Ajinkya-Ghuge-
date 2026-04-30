using System;

namespace Level3_OOPs_Advanced
{
    public class Program107_Abstraction
    {
        public static void Run()
        {
            Payment payment = new CreditCardPayment();
            payment.ProcessPayment(2500m);
        }

        private abstract class Payment
        {
            public abstract void ProcessPayment(decimal amount);
        }

        private class CreditCardPayment : Payment
        {
            public override void ProcessPayment(decimal amount)
            {
                Console.WriteLine($"Processed credit card payment of {amount:C}.");
            }
        }
    }
}
