using Dapper;
using MyProjet.Models;
using System.Collections.Generic;
using System.Data;

namespace MyProjet.Data
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly IDbConnection _conn;
        public ReviewRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Review> GetAllReview()
        {
            return _conn.Query<Review>("SELECT * FROM reviews;");
        }
        public Review GetReview(int id)
        {
            return _conn.QuerySingle<Review>("SELECT * FROM reviews WHERE ReviewID = @id",
               new { id });
        }

        public void UpdateReview(Review review)
        {
            _conn.Execute("UPDATE reviews SET Reviewer = @reviewer, Comment = @comment, Rating = @rating WHERE ReviewID = @id",
                new { reviewer = review.Reviewer, comment = review.Comment, rating = review.Rating, id = review.ReviewID });

        }
        public void InsertReview(Review ReviewToInsert)
        {
            _conn.Execute("INSERT INTO reviews (reviewer, comment, rating, ProductID) VALUES (@reviewer, @comment, @rating, @ProductID);",
                new { reviewer = ReviewToInsert.Reviewer, comment = ReviewToInsert.Comment, rating = ReviewToInsert.Rating, ProductID = ReviewToInsert.ProductID });
        }
        //public IEnumerable<Category> GetCategories()
        //{
        //    return _conn.Query<Category>("SELECT * FROM categories;");
        //}
        //public Product AssignCategory()
        //{
        //    var categoryList = GetCategories();
        //    var product = new Product();
        //    product.Categories = categoryList;

        //    return product;
        //}
        //public void DeleteProduct(Product product)
        //{
        //    _conn.Execute("DELETE FROM REVIEWS WHERE ProductID = @id;",
        //                               new { id = product.ProductID });
        //    _conn.Execute("DELETE FROM Sales WHERE ProductID = @id;",
        //                               new { id = product.ProductID });
        //    _conn.Execute("DELETE FROM Products WHERE ProductID = @id;",
        //                               new { id = product.ProductID });
        //}


    }
}
