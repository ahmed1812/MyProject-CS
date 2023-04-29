using Dapper;
using MyProjet.Models;
using System.Collections.Generic;
using System.Data;
using System.Net.Mail;

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
        public void InsertEmployee(Employee employeetToInsert)
        {
            _conn.Execute("INSERT INTO Employees (FirstName, MiddleInitial, LastName, EmailAddress, PhoneNumber, Title, DateOfBirth) VALUES (@firstName, @middleInitial, @lastName, @emailAddress, @phoneNumber, @title, @dateOfBirth);",
                new { firstName = employeetToInsert.FirstName, @middleInitial = employeetToInsert.MiddleInitial, lastName = employeetToInsert.LastName, emailAddress = employeetToInsert.EmailAddress, phoneNumber = employeetToInsert.PhoneNumber, title = employeetToInsert.Title, dateOfBirth = employeetToInsert.DateOfBirth });
        }
        public Employee Assign()
        {
            var emp = new Employee();

            return emp;
        }

        public void DeleteEmployee(Employee employee)
        {
            _conn.Execute("DELETE FROM Sales WHERE EmployeeID = @id;",
                                       new { id = employee.EmployeeID });
            _conn.Execute("DELETE FROM Employees WHERE EmployeeID = @id;",
                                       new { id = employee.EmployeeID });
        }

    }
}
