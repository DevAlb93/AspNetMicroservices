using Catalog.API.Data;
using Catalog.API.Entities;

namespace Catalog.API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ICatalogContext _catalogContext;
        public ProductRepository(ICatalogContext catalogContext)
        {
            _catalogContext = catalogContext ??
                throw new ArgumentNullException(nameof(catalogContext));
        }
        public Task<Product> GetProduct(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
