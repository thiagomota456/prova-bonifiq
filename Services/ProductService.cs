using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services
{
	public class ProductService
	{
		TestDbContext _ctx;

		public ProductService(TestDbContext ctx)
		{
			_ctx = ctx;
		}

        public ProductList ListProducts(int page, int pageSize)
        {
            var totalCount = _ctx.Products.Count();
            var skipAmount = pageSize * (page - 1);
            var products = _ctx.Products.Skip(skipAmount).Take(pageSize).ToList();

            return new ProductList()
            {
                HasNext = (skipAmount + pageSize) < totalCount,
                TotalCount = totalCount,
                Elementos = products
            };
        }

    }
}
