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
        //EmployeeID, FirstName, MiddleInitial, LastName, EmailAddress, PhoneNumber, Title, DateOfBirth
        public void UpdateEmployee(Employee employee)
        {
            _conn.Execute("UPDATE Employees SET FirstName = @firstName, MiddleInitial = @midName, LastName = @lastName, EmailAddress = @email, PhoneNumber = @phone, Title = @title, DateOfBirth = @date WHERE EmployeeID = @id",
                new { firstName = employee.FirstName, midName = employee.MiddleInitial, lastName = employee.LastName, email = employee.EmailAddress, phone = employee.EmailAddress, title = employee.Title, date = employee.DateOfBirth, id = employee.EmployeeID });
        }
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
