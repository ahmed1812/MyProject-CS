using Microsoft.AspNetCore.Mvc;
using MyProjet.Data;
using MyProjet.Models;

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

            var review = repo.GetReview(id);

            return View(review);
        }
        public IActionResult UpdateReview(int id)
        {
            Review rev = repo.GetReview(id);

            if (rev == null)
            {
                return View("ReviewNotFound");
            }

            return View(rev);
        }
        public IActionResult UpdateReivewToDatabase(Review review)
        {
            repo.UpdateReview(review);

            return RedirectToAction("ViewReview", new { id = review.ReviewID });
        }


    }
}
