using System.Collections.Generic;

namespace MyProjet.Models
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public ProductReviewVM GetProduct(int id);

    }
}
