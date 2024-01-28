using Microsoft.AspNetCore.Mvc;
using ProvaPub.Services;
using ProvaPub.Strategies;

namespace ProvaPub.Controllers.Base
{
    public class ControllerBase2 : ControllerBase
    {
        protected readonly CustomerService _customerService;
        protected readonly ProductService _productService;
        protected readonly RandomService _randomService;
        protected readonly OrderService _orderService;
        protected readonly PaymentStrategyFactory _paymentStrategyFactory;

        public ControllerBase2(ProductService productService, CustomerService customerService, RandomService randomService, OrderService orderService, PaymentStrategyFactory paymentStrategyFactory)
        {
            _productService = productService;
            _customerService = customerService;
            _randomService = randomService;
            _orderService = orderService;
            _paymentStrategyFactory = paymentStrategyFactory;
        }
    }
}
