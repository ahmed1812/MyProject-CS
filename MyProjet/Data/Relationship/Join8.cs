using Dapper;
using MyProjet.Models;
using System.Collections.Generic;
using System.Data;

namespace MyProjet.Data.Relationship
{
    public class Join8 : IJoin8
    {
        private readonly IDbConnection _conn;

        public Join8(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Department> GetParentChildGrandChildGreatGrandChildData()
        {
            string sql = @"SELECT d.Name as DepartmentName, e.FirstName, e.LastName, e.Title
                            FROM bestbuy.departments as d
                            JOIN bestbuy.categories as c ON d.DepartmentID = c.DepartmentID
                            JOIN bestbuy.products as p ON c.CategoryID = p.CategoryID
                            JOIN bestbuy.sales as s ON p.ProductID = s.ProductID
                            JOIN bestbuy.employees as e ON s.EmployeeID = e.EmployeeID
                            WHERE s.Date >= '2017-01-01' and s.Date <= '2017-12-31'
                            ORDER BY d.Name, e.FirstName, e.LastName";

            var data = _conn.Query<Department, Category, Product, Sale,Employee, Department>(
                sql,
                (dep, cat, pro, sal, emp) =>
                {

                    sal.Employees.Add(emp);

                    if (!pro.Sales.Contains(sal))
                    {
                        pro.Sales.Add(sal);
                    }

                    if (!cat.Products.Contains(pro))
                    {
                        cat.Products.Add(pro);
                    }

                    if (!dep.Categories.Contains(cat))
                    {
                        dep.Categories.Add(cat);
                    }

                    return dep;
                },
                splitOn: "DepartmentID, CategoryID, ProductID, EmployeeID"
            );

            return data;
        }

    }
}
