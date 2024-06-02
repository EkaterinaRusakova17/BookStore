namespace BookStore
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }