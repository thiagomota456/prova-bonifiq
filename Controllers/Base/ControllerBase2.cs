using Microsoft.AspNetCore.Mvc;
using ProvaPub.Services;

namespace ProvaPub.Controllers.Base
{
    public class ControllerBase2 : ControllerBase
    {
        protected readonly CustomerService _customerService;
        protected readonly ProductService _productService;
        protected readonly RandomService _randomService;
        protected readonly OrderService _orderService;

        public ControllerBase2(ProductService productService, CustomerService customerService, RandomService randomService, OrderService orderService)
        {
            _productService = productService;
            _customerService = customerService;
            _randomService = randomService;
            _orderService = orderService;
        }

        public ProductService ProductService { get; }
        public CustomerService CustomerService { get; }
        public RandomService RandomService { get; }
    }
}
