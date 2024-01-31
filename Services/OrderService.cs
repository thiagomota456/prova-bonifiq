using Microsoft.EntityFrameworkCore.Infrastructure;
using ProvaPub.Models;
using ProvaPub.Repository;
using ProvaPub.Services.Base;
using ProvaPub.Strategies;

namespace ProvaPub.Services
{
	public class OrderService : ServiceBase
	{
        public OrderService(TestDbContext ctx) : base(ctx)
        {
        }

        public async Task<Order> PayOrder(IPaymentStrategy paymentStrategy, decimal paymentValue, int customerId)
        {
            await paymentStrategy.Pay(paymentValue);

            Customer? customer = _ctx.Customers.FirstOrDefault(c => c.Id == customerId);

            if(customer == null)
                throw new Exception("Informe o cliente");

            Order newOrder = new()
            {
                Value = paymentValue,
                CustomerId = customerId,
                OrderDate = DateTime.Now,
                Customer = customer
            };

            _ctx.Orders.Add(newOrder);
            await _ctx.SaveChangesAsync();

            return newOrder;
        }
    }
}
