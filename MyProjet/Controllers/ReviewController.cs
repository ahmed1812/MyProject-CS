using Microsoft.AspNetCore.Mvc;
using MyProjet.Data;

namespace MyProjet.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewRepository repo;
        public ReviewController(IReviewRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var review = repo.GetAllReview();
            return View(review);
        }
        public IActionResult ViewReview(int id)
        {

            var product = repo.GetReview(id);

            return View(product);
        }
    }
}
