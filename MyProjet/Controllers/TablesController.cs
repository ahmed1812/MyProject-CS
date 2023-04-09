using Microsoft.AspNetCore.Mvc;
using MyProjet.Data.Relationship;
using MyProjet.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace MyProjet.Controllers
{
    public class TablesController : Controller
    {
        private readonly IDbConnection _conn;
        private readonly string _connectionString = "Server=localhost;Database=bestbuy;uid=root;Pwd=root;Port=3306;";


        public TablesController(IDbConnection conn)
        {
            _conn = conn;
        }
    
        public ActionResult Index()
        {
            string query = "SELECT products.Name, AVG(reviews.Rating) as AverageRating " +
                       "FROM bestbuy.products " +
                       "LEFT JOIN bestbuy.reviews ON products.ProductID = reviews.ProductID " +
                       "GROUP BY products.ProductID " +
                       "HAVING COUNT(reviews.ReviewID) > 0;";

        List<ProductReview> productReviews = new List<ProductReview>();

    using (var _conn = new MySqlConnection(_connectionString))
    {
        var adapter = new MySqlDataAdapter(query, _conn);

    DataSet dataSet = new DataSet();
    adapter.Fill(dataSet);

        foreach (DataRow row in dataSet.Tables[0].Rows)
        {
        ProductReview productReview = new ProductReview();
    productReview.Name = row["Name"].ToString();
    productReview.AverageRating = double.Parse(row["AverageRating"].ToString());
    productReviews.Add(productReview);
        }
    }

    return View(productReviews);
}

        
    }
}
