using Microsoft.AspNetCore.Mvc;
using ProvaPub.Controllers.Base;
using ProvaPub.Services;

namespace ProvaPub.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class Parte1Controller :  ControllerBase2
	{
        public Parte1Controller(ProductService productService, CustomerService customerService, RandomService randomService, OrderService orderService) : base(productService, customerService, randomService, orderService)
        {
        }

        [HttpGet]
		public int Index()
		{
			return _randomService.GetRandom();
		}
	}
}
