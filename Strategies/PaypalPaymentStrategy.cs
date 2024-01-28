namespace ProvaPub.Strategies
{
    public class PaypalPaymentStrategy : IPaymentStrategy
    {
        public async Task<string> Pay(decimal paymentValue)
        {
            return await Task.FromResult($"Efetuando pagamento Paypal no valor de {paymentValue}");
        }
    }
}
