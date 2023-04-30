using Dapper;
using MyProjet.Models;
using System.Collections.Generic;
using System.Data;

namespace MyProjet.Data.Entity
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly IDbConnection _conn;
        public CategoryRepo(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Category> GetAllCategorys()
        {
            return _conn.Query<Category>("SELECT * FROM categories;");
        }
        public Category GetCategory(int id)
        {
            return _conn.QuerySingle<Category>("SELECT * FROM categories WHERE CategoryID = @id",
               new { id });
        }
        //CategoryID, Name, DepartmentID
        public void UpdateCategory(Category category)
        {
            _conn.Execute("UPDATE categories SET Name = @name  WHERE CategoryID = @id",
                new {  name = category.Name, id = category.CategoryID });
        }
        public void InsertCategory(Category categorytToInsert)
        {
            _conn.Execute("INSERT INTO categories (Name, DepartmentID) VALUES (@name, @departmentID);",
                new {name = categorytToInsert.Name, departmentID = categorytToInsert.DepartmentID});
        }
        public IEnumerable<Department> GetDepartments()
        {
            return _conn.Query<Department>("SELECT * FROM categories;");
        }
        public Category Assign()
        {
            var dep = GetDepartments();
            var cat = new Category();
            cat.Departments = dep;

            return cat;
        }

        public void DeleteCategory(Category Category)
        {
            _conn.Execute("DELETE FROM products WHERE CategoryID = @id;",
                                       new { id = Category.CategoryID });
            _conn.Execute("DELETE FROM categories WHERE CategoryID = @id;",
                                       new { id = Category.CategoryID });
        }
    }
}
