using Microsoft.AspNetCore.Mvc;
using MyProjet.Data.Relationship;

namespace MyProjet.Controllers
{
    public class TablesController : Controller
    {
        private readonly IJoinRepo repo;
        public TablesController(IJoinRepo repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var data = repo.GetJoinTables();
            return View(data);
        }
    }
}
