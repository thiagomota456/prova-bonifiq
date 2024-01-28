namespace ProvaPub.Strategies
{
    public class PixPaymentStrategy : IPaymentStrategy
    {
        public async Task<string> Pay(decimal paymentValue)
        {
            return await Task.FromResult($"Efetuando pagamento Pix no valor de {paymentValue}");
        }
    }
}
