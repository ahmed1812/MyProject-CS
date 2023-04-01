using MyProjet.Models;
using System.Collections.Generic;

namespace MyProjet.Data.Entity
{
    public interface IReviewRepository
    {
        public IEnumerable<Review> GetAllReview();
        public Review GetReview(int id);
        public void UpdateReview(Review review);
        public void InsertReview(Review ReviewToInsert);
        public IEnumerable<Product> GetProducts();
        public Review AssignProduct();
    }
}
