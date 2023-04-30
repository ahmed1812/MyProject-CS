using MyProjet.Models;
using System.Collections.Generic;

namespace MyProjet.Data.Entity
{
    public interface IDepartmentRepo
    {
        public IEnumerable<Department> GetAllDepartments();
        public Department GetDepartment(int id);
        public void UpdateDepartment(Department department);
        public void InsertDepartment(Department departmentToInsert);
        //public IEnumerable<Category> GetCategories();
        public Department Assign();
        public void DeleteDepartment(Department department);
    }
}
