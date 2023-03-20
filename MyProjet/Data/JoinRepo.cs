using Dapper;
using MyProjet.Models;
using System.Collections.Generic;
using System.Data;

namespace MyProjet.Data
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
            var query = @"SELECT * FROM bestbuy.products JOIN bestbuy.reviews ON products.ProductID = reviews.ProductID";
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
