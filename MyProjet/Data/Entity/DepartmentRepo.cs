using Dapper;
using MyProjet.Models;
using System.Collections.Generic;
using System.Data;

namespace MyProjet.Data.Entity
{
    public class DepartmentRepo : IDepartmentRepo
    {
        private readonly IDbConnection _conn;
        public DepartmentRepo(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Department> GetAllDepartments()
        {
            return _conn.Query<Department>("SELECT * FROM Departments;");
        }
        public Department GetDepartment(int id)
        {
            return _conn.QuerySingle<Department>("SELECT * FROM Departments WHERE DepartmentID = @id",
               new { id });
        }
        //, Name DepartmentID
        public void UpdateDepartment(Department department)
        {
            _conn.Execute("UPDATE Departments SET  Name = @name WHERE DepartmentID = @id",
                new { name = department.Name, id = department.DepartmentID });
        }
        public void InsertDepartment(Department departmenttToInsert)
        {
            _conn.Execute("INSERT INTO Departments (Name) VALUES (@name);",
                new { name = departmenttToInsert.Name});
        }
        public Department Assign()
        {
            var emp = new Department();

            return emp;
        }

        public void DeleteDepartment(Department department)
        {
            _conn.Execute("DELETE FROM categories WHERE DepartmentID = @id;",
                                       new { id = department.DepartmentID });
            _conn.Execute("DELETE FROM Departments WHERE DepartmentID = @id;",
                                       new { id = department.DepartmentID });
        }
    }
}
