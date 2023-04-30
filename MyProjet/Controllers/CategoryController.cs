using Microsoft.AspNetCore.Mvc;
using MyProjet.Data.Entity;
using MyProjet.Models;

namespace MyProjet.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepo repo;
        public CategoryController(ICategoryRepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var Categorys = repo.GetAllCategorys();
            return View(Categorys);
        }
        public IActionResult ViewCategory(int id)
        {

            var Category = repo.GetCategory(id);

            return View(Category);
        }
        public IActionResult UpdateCategory(int id)
        {
            Category emp = repo.GetCategory(id);

            if (emp == null)
            {
                return View("CategoryNotFound");
            }

            return View(emp);
        }
        public IActionResult UpdateCategoryToDatabase(Category category)
        {
            repo.UpdateCategory(category);

            return RedirectToAction("ViewCategory", new { id = category.CategoryID });
        }
        public IActionResult InsertCategory()
        {
            var prod = repo.Assign();

            return View(prod);
        }
        public IActionResult InsertCategoryToDatabase(Category categoryToInsert)
        {
            repo.InsertCategory(categoryToInsert);

            return RedirectToAction("Index");
        }
        public IActionResult DeleteCategory(Category category)
        {
            repo.DeleteCategory(category);

            return RedirectToAction("Index");
        }
    }
}
