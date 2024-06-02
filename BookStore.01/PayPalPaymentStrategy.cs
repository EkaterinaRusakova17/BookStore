using System;

namespace BookStore
{
    public class PayPalPaymentStrategy : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paying {amount} using PayPal.");
        }
    }
}