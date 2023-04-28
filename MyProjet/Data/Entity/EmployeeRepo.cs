using Dapper;
using MyProjet.Models;
using System.Collections.Generic;
using System.Data;

namespace MyProjet.Data.Entity
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly IDbConnection _conn;
        public EmployeeRepo(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _conn.Query<Employee>("SELECT * FROM Employees;");
        }
        public Employee GetEmployee(int id)
        {
            return _conn.QuerySingle<Employee>("SELECT * FROM Employees WHERE EmployeeID = @id",
               new { id });
        }

        //public void UpdateEmployee(Employee employee)
        //{
        //    _conn.Execute("UPDATE products SET Name = @name, Price = @price WHERE ProductID = @id",
        //        new { name = product.Name, price = product.Price, id = product.ProductID });

        //}
        //public void InsertEmployee(Employee employeetToInsert)
        //{
        //    _conn.Execute("INSERT INTO products (NAME, PRICE, CATEGORYID) VALUES (@name, @price, @categoryID);",
        //        new { name = productToInsert.Name, price = productToInsert.Price, categoryID = productToInsert.CategoryID });
        //}


        //public void DeleteEmployee(Employee employee)
        //{
        //    _conn.Execute("DELETE FROM Sales WHERE ProductID = @id;",
        //                               new { id = employee.ProductID });
        //    _conn.Execute("DELETE FROM Products WHERE ProductID = @id;",
        //                               new { id = employee.ProductID });
        //}

    }
}
