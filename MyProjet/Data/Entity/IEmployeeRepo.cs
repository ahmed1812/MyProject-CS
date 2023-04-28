using MyProjet.Models;
using System.Collections.Generic;

namespace MyProjet.Data.Entity
{
    public interface IEmployeeRepo
    {
        public IEnumerable<Employee> GetAllEmployees();
        public Employee GetEmployee(int id);
        public void UpdateEmployee(Employee employee);
        //public void InsertEmployee(Employee employeeToInsert);
        //public IEnumerable<Category> GetCategories();
        //public Employee AssignCategory();
        //public void DeleteEmployee(Employee Employee);
    }
}
