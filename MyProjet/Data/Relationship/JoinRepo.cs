using Dapper;
using MyProjet.Models;
using System.Collections.Generic;
using System.Data;

namespace MyProjet.Data.Relationship
{
    public class JoinRepo : IJoinRepo
    {
        private readonly IDbConnection _conn;

        public JoinRepo(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Product> GetJoinTables()
        {
            var query = @"SELECT products.Name, AVG(reviews.Rating) 
                            FROM bestbuy.products 
                            LEFT JOIN bestbuy.reviews ON products.ProductID = reviews.ProductID 
                            GROUP BY products.ProductID 
                            HAVING COUNT(reviews.ReviewID) > 0;
                           ";
            var results = _conn.Query<Product, Review, Product>(query,
                (p, r) =>
                {
                    p.Reviews.Add(r);
                    return p;
                },
                splitOn: "ProductID");
            return results;
        }
    }
}
