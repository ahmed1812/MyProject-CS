using Dapper;
using MyProjet.Models;
using System.Collections.Generic;
using System.Data;

namespace MyProjet.Data.Relationship
{
    public class Join3Tables : IJoin3Tables
    {
        private readonly IDbConnection _conn;
        public Join3Tables(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Product> GetParentChildGrandChildData()
        {
            string sql = @"SELECT p.*, s.*, e.*
                   FROM products p
                   JOIN sales s ON p.ProductID = s.ProductID
                   JOIN employees e ON s.EmployeeID = s.EmployeeID 
                   WHERE p.ProductID = 4";

            var data = _conn.Query<Product, Sale, Employee, Product>(
                sql,
                (product, sale, employee) =>
                {
                    sale.Employees.Add(employee);

                    if (!product.Sales.Contains(sale))
                    {
                        product.Sales.Add(sale);
                    }

                    return product;
                },
                splitOn: "ProductID, EmployeeID"
            );

            return data;
        }

    }
}
