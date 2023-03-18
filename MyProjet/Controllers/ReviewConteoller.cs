using Dapper;
using Microsoft.AspNetCore.Mvc;
using MyProjet.Models;
using System.Data;
using System.Linq;

namespace MyProjet.Controllers
{
    public class ReviewConteoller : Controller
    {
        private readonly IDbConnection _conn;

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            string sql = @"select * from bestbuy.reviews inner join bestbuy.products on reviews.ProductID = products.ProductID where products.ProductID = 2;";
            var sal = _conn.Query<Review>(sql).ToList();
            return View(sal);

        }
    }
}
