using Microsoft.Extensions.Configuration;

namespace Catalog.API.Data
{
    public class CatalogContext :ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            var connectionString = configuration
                .GetValue<string>("ConnectionStrings:ConnectionString");
        }
    }
}
