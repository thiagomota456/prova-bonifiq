namespace ProvaPub.Strategies
{
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        public async Task<string> Pay(decimal paymentValue)
        {
            return await Task.FromResult($"Efetuando pagamento Cartão de Crédito no valor de {paymentValue}");
        }
    }
}
