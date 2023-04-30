using Microsoft.AspNetCore.Mvc;
using MyProjet.Data.Entity;
using MyProjet.Models;

namespace MyProjet.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepo repo;
        public DepartmentController(IDepartmentRepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var Departments = repo.GetAllDepartments();
            return View(Departments);
        }
        public IActionResult ViewDepartment(int id)
        {

            var Department = repo.GetDepartment(id);

            return View(Department);
        }
        public IActionResult UpdateDepartment(int id)
        {
            Department emp = repo.GetDepartment(id);

            if (emp == null)
            {
                return View("DepartmentNotFound");
            }

            return View(emp);
        }
        public IActionResult UpdateDepartmentToDatabase(Department Department)
        {
            repo.UpdateDepartment(Department);

            return RedirectToAction("ViewDepartment", new { id = Department.DepartmentID });
        }
        public IActionResult InsertDepartment()
        {
            var prod = repo.Assign();

            return View(prod);
        }
        public IActionResult InsertDepartmentToDatabase(Department DepartmentToInsert)
        {
            repo.InsertDepartment(DepartmentToInsert);

            return RedirectToAction("Index");
        }
        public IActionResult DeleteDepartment(Department Department)
        {
            repo.DeleteDepartment(Department);

            return RedirectToAction("Index");
        }
    }
}
