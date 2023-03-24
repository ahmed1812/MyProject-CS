using Microsoft.AspNetCore.Mvc;
using MyProjet.Data;

namespace MyProjet.Controllers
{
    public class PSEController : Controller
    {
        private readonly IJoin3Tables repo;
        public PSEController(IJoin3Tables repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var data = repo.GetParentChildGrandChildData();
            return View(data);
        }
    }
}
