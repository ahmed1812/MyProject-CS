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
            return _conn.Query<Category>("SELECT * FROM Categorys;");
        }
        public Category GetCategory(int id)
        {
            return _conn.QuerySingle<Category>("SELECT * FROM Categorys WHERE CategoryID = @id",
               new { id });
        }
        //CategoryID, FirstName, MiddleInitial, LastName, EmailAddress, PhoneNumber, Title, DateOfBirth
        public void UpdateCategory(Category Category)
        {
            _conn.Execute("UPDATE Categorys SET FirstName = @firstName, MiddleInitial = @midName, LastName = @lastName, EmailAddress = @email, PhoneNumber = @phone, Title = @title, DateOfBirth = @date WHERE CategoryID = @id",
                new { firstName = Category.FirstName, midName = Category.MiddleInitial, lastName = Category.LastName, email = Category.EmailAddress, phone = Category.EmailAddress, title = Category.Title, date = Category.DateOfBirth, id = Category.CategoryID });
        }
        public void InsertCategory(Category CategorytToInsert)
        {
            _conn.Execute("INSERT INTO Categorys (FirstName, MiddleInitial, LastName, EmailAddress, PhoneNumber, Title, DateOfBirth) VALUES (@firstName, @middleInitial, @lastName, @emailAddress, @phoneNumber, @title, @dateOfBirth);",
                new { firstName = CategorytToInsert.FirstName, @middleInitial = CategorytToInsert.MiddleInitial, lastName = CategorytToInsert.LastName, emailAddress = CategorytToInsert.EmailAddress, phoneNumber = CategorytToInsert.PhoneNumber, title = CategorytToInsert.Title, dateOfBirth = CategorytToInsert.DateOfBirth });
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
            _conn.Execute("DELETE FROM Categorys WHERE CategoryID = @id;",
                                       new { id = Category.CategoryID });
        }
    }
}
