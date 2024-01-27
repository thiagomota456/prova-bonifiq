using Microsoft.AspNetCore.Mvc;
using ProvaPub.Services;

namespace ProvaPub.Controllers.Base
{
    public class ControllerBase2 : ControllerBase
    {
        protected readonly CustomerService _customerService;
        protected readonly ProductService _productService;

        public ControllerBase2(ProductService productService, CustomerService customerService)
        {
            _productService = productService;
            _customerService = customerService;
        }
    }
}
