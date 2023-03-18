using Dapper;
using System.Collections.Generic;
using System.Data;

namespace MyProjet.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;
        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM PRODUCTS;");
        }
        public ProductReviewVM GetProduct(int id)
        {
            return (ProductReviewVM)_conn.Query<ProductReviewVM>("select * from sales inner join products on sales.ProductID = products.ProductID where products.ProductID = @id",
                new { id = id });
        }
    }
}
