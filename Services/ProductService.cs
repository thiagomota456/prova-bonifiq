using ProvaPub.Models;
using ProvaPub.Repository;
using ProvaPub.Services.Base;

namespace ProvaPub.Services
{
    public class ProductService : ServiceBase
    {
        public ProductService(TestDbContext ctx) : base(ctx)
        {
        }
    }
}
