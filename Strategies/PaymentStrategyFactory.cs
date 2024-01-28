namespace ProvaPub.Strategies
{
    public class PaymentStrategyFactory
    {
        public IPaymentStrategy GetPaymentStrategy(string paymentMethod)
        {
            switch (paymentMethod.ToLower())
            {
                case "pix":
                    return new PixPaymentStrategy();
                case "creditcard":
                    return new CreditCardPaymentStrategy();
                case "paypal":
                    return new PaypalPaymentStrategy();
                default:
                    throw new ArgumentException("Método de pagamento não suportado", nameof(paymentMethod));
            }
        }
    }

}
