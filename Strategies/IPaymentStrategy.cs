namespace ProvaPub.Strategies
{
    public interface IPaymentStrategy
    {
        Task<string> Pay(decimal paymentValue);
    }
}
