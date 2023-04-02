using Microsoft.AspNetCore.Mvc;
using MyProjet.Data.Relationship;

namespace MyProjet.Controllers
{
    public class JoinTables8Controller : Controller
    {
        private readonly IJoin8 repo;
        public JoinTables8Controller(IJoin8 repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var data = repo.GetParentChildGrandChildGreatGrandChildData();
            return View(data);
        }
    }
}
