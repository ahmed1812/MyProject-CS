using System.Collections.Generic;

namespace MyProjet.Models
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);

    }
}
