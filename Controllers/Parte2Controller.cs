﻿using Microsoft.AspNetCore.Mvc;
using ProvaPub.Controllers.Base;
using ProvaPub.Models;
using ProvaPub.Repository;
using ProvaPub.Services;
using ProvaPub.Strategies;

namespace ProvaPub.Controllers
{
	
	[ApiController]
	[Route("[controller]")]
	public class Parte2Controller :  ControllerBase2
	{
        public Parte2Controller(ProductService productService, CustomerService customerService, RandomService randomService, OrderService orderService, PaymentStrategyFactory paymentStrategyFactory) : base(productService, customerService, randomService, orderService, paymentStrategyFactory)
        {
        }

        [HttpGet("products")]
		public Lista<Product> ListProducts(int page)
		{
            int pageSize = 10;
            return	_productService.Listar<Product>(page, pageSize);
        }

		[HttpGet("customers")]
		public Lista<Customer> ListCustomers(int page)
		{
            int pageSize = 10;
            return _customerService.Listar<Customer>(page, pageSize);
        }
	}
}
