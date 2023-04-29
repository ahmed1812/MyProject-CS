using Microsoft.AspNetCore.Mvc;
using MyProjet.Data.Entity;
using MyProjet.Models;

namespace MyProjet.Controllers
{
    public class SaleController : Controller
    {
        private readonly ISaleRepo repo;
        public SaleController(ISaleRepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var Sales = repo.GetAllSales();
            return View(Sales);
        }
        public IActionResult ViewSale(int id)
        {

            var Sale = repo.GetSale(id);

            return View(Sale);
        }
        public IActionResult UpdateSale(int id)
        {
            Sale prod = repo.GetSale(id);

            if (prod == null)
            {
                return View("SaleNotFound");
            }

            return View(prod);
        }
        public IActionResult UpdateSaleToDatabase(Sale sale)
        {
            repo.UpdateSale(sale);

            return RedirectToAction("ViewSale", new { id = sale.SalesID });
        }
        public IActionResult InsertSale()
        {
            var prod = repo.AssignAll();

            return View(prod);
        }
        public IActionResult InsertSaleToDatabase(Sale saleToInsert)
        {
            repo.InsertSale(saleToInsert);

            return RedirectToAction("Index");
        }
        public IActionResult DeleteSale(Sale Sale)
        {
            repo.DeleteSale(Sale);

            return RedirectToAction("Index");
        }
    }
}
