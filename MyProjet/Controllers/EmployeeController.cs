using Microsoft.AspNetCore.Mvc;
using MyProjet.Data.Entity;
using MyProjet.Models;

namespace MyProjet.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepo repo;
        public EmployeeController(IEmployeeRepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var employees = repo.GetAllEmployees();
            return View(employees);
        }
        public IActionResult ViewEmployee(int id)
        {

            var employee = repo.GetEmployee(id);

            return View(employee);
        }
        //public IActionResult UpdateEmployee(int id)
        //{
        //    Employee emp = repo.GetEmployee(id);

        //    if (emp == null)
        //    {
        //        return View("EmployeeNotFound");
        //    }

        //    return View(emp);
        //}
        //public IActionResult UpdateEmployeeToDatabase(Employee employee)
        //{
        //    repo.UpdateEmployee(employee);

        //    return RedirectToAction("ViewProduct", new { id = employee.EmployeeID });
        //}
        //public IActionResult InsertProduct()
        //{
        //    var prod = repo.AssignCategory();

        //    return View(prod);
        //}
        //public IActionResult InsertEmployeeToDatabase(Employee employeeToInsert)
        //{
        //    repo.InsertEmployee(employeeToInsert);

        //    return RedirectToAction("Index");
        //}
        //public IActionResult DeleteEmployee(Employee employee)
        //{
        //    repo.DeleteEmployee(employee);

        //    return RedirectToAction("Index");
        //}
    }
}
