using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services.Base
{
    public class ServiceBase
    {
        protected readonly TestDbContext _ctx;
        public ServiceBase(TestDbContext ctx) 
        {
            _ctx = ctx;
        }

        public Lista<T> Listar<T>(int page, int pageSize) where T : class
        {
            int totalCount = _ctx.Set<T>().Count();
            var skipAmount = pageSize * (page - 1);
            var items = _ctx.Set<T>().Skip(skipAmount).Take(pageSize).ToList();

            return new Lista<T>()
            {
                HasNext = (skipAmount + pageSize) < totalCount,
                TotalCount = totalCount,
                Elementos = items
            };
        }
    }
}
