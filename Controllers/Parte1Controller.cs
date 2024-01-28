using Microsoft.AspNetCore.Mvc;
using ProvaPub.Controllers.Base;
using ProvaPub.Services;
using ProvaPub.Strategies;

namespace ProvaPub.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class Parte1Controller :  ControllerBase2
	{
        public Parte1Controller(ProductService productService, CustomerService customerService, RandomService randomService, OrderService orderService, PaymentStrategyFactory paymentStrategyFactory) : base(productService, customerService, randomService, orderService, paymentStrategyFactory)
        {
        }

        [HttpGet]
		public int Index()
		{
			return _randomService.GetRandom();
		}
	}
}
