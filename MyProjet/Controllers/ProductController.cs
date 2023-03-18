using Dapper;
using Microsoft.AspNetCore.Mvc;
using MyProjet.Models;
using System.Data;
using System.Linq;

namespace MyProjet.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repo;
        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var products = repo.GetAllProducts();
            return View(products);
        }
        public IActionResult ViewProduct(int id)
        {
            
            var product = repo.GetProduct(id);

            return View(product);
        }
        
    }
}
