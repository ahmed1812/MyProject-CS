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
            var query = @"SELECT *
                            FROM bestbuy.products p
                            JOIN bestbuy.reviews r ON p.ProductID = r.ProductID
                            WHERE r.Rating = 5
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
