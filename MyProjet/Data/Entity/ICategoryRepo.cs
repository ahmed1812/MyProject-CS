using MyProjet.Models;
using System.Collections.Generic;

namespace MyProjet.Data.Entity
{
    public interface ICategoryRepo
    {
        public IEnumerable<Category> GetAllCategorys();
        public Category GetCategory(int id);
        public void UpdateCategory(Category category);
        public void InsertCategory(Category categoryToInsert);
        public IEnumerable<Department> GetDepartments();
        public Category Assign();
        public void DeleteCategory(Category category);
    }
}
