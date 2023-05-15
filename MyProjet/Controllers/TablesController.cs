using Dapper;
using Microsoft.AspNetCore.Mvc;
using MyProjet.Data.Relationship;
using MyProjet.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;

namespace MyProjet.Controllers
{
    public class TablesController : Controller
    {
        private readonly IDbConnection _conn;
        public string query { get; set; }
        //private readonly string _connectionString = "Server=localhost;Database=bestbuy;uid=root;Pwd=root;Port=3306;";
        public TablesController(IDbConnection conn)
        {
            _conn = conn;
        }
        //3
        public ActionResult Index()
        {
            query = "SELECT products.Name, AVG(reviews.Rating) as AverageRating " +
                       "FROM bestbuy.products " +
                       "LEFT JOIN bestbuy.reviews ON products.ProductID = reviews.ProductID " +
                       "GROUP BY products.ProductID " +
                       "HAVING COUNT(reviews.ReviewID) > 0;";

            List<ProductReview> productReviews = new List<ProductReview>();

            using (var conn = _conn)
            {
                var adapter = new MySqlDataAdapter(query, (MySqlConnection)conn);
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
        //1
        public ActionResult ProdCateg()
        {
            query = "SELECT products.Name, products.Price " +
                "FROM bestbuy.products JOIN bestbuy.categories " +
                "ON products.CategoryID = categories.CategoryID" +
                "WHERE categories.Name = 'Computers';";

            List<ProductCategory> productCategorys = new List<ProductCategory>();

            using (var conn = _conn)
            {
                var adapter = new MySqlDataAdapter(query, (MySqlConnection)conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    ProductCategory productCategory = new ProductCategory();
                    productCategory.Name = row["Name"].ToString();
                    productCategory.Price = double.Parse(row["Price"].ToString());
                    productCategorys.Add(productCategory);
                }
            }
            return View(productCategorys);
        }
        //4
        public ActionResult EmpSal()
        {
            query = "SELECT employees.FirstName, employees.LastName, SUM(sales.Quantity * sales.PricePerUnit) AS TotalSale " +
                "FROM bestbuy.employees JOIN bestbuy.sales " +
                "ON employees.EmployeeID = sales.EmployeeID " +
                "WHERE sales.Date >= '2017-01-01' AND sales.Date <= '2017-12-31' " +
                "GROUP BY employees.EmployeeID;";

            List<EmpSal> empSals = new List<EmpSal>();

            using (var conn = _conn)
            {
                var adapter = new MySqlDataAdapter(query, (MySqlConnection)conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    EmpSal empSal = new EmpSal();
                    empSal.FirstName = row["FirstName"].ToString();
                    empSal.LastNmae = row["LastName"].ToString();
                    empSal.Total = double.Parse(row["TotalSale"].ToString());
                    empSals.Add(empSal);
                }
            }
            return View(empSals);
        }
        //2
        public ActionResult CatProDep()
        {
            query = "SELECT categories.Name as cname, departments.Name as dname, products.Name as pname " +
                "FROM bestbuy.categories JOIN bestbuy.products " +
                "ON categories.CategoryID = products.CategoryID JOIN bestbuy.departments " +
                "ON categories.DepartmentID = departments.DepartmentID " +
                "WHERE products.OnSale = 1;";

            List<CategroeProductDepartment> categroeProductDepartments = new List<CategroeProductDepartment>();

            using (var conn = _conn)
            {
                var adapter = new MySqlDataAdapter(query, (MySqlConnection)conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    CategroeProductDepartment categroeProductDepartment = new CategroeProductDepartment();
                    categroeProductDepartment.CName = row["cname"].ToString();
                    categroeProductDepartment.DName = row["dname"].ToString();
                    categroeProductDepartment.PName = row["pname"].ToString();
                    categroeProductDepartments.Add(categroeProductDepartment);
                }
            }
            return View(categroeProductDepartments);
        }
        //5
        public ActionResult ProdSt()
        {
            query = "SELECT products.Name, products.StockLevel " +
                "FROM bestbuy.products " +
                "ORDER BY products.StockLevel ASC LIMIT 3;";

            List<Product> products = new List<Product>();

            using (var conn = _conn)
            {
                var adapter = new MySqlDataAdapter(query, (MySqlConnection)conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    Product product = new Product();
                    product.Name = row["Name"].ToString();
                    product.StockLevel = row["StockLevel"].ToString();
                    products.Add(product);
                }
            }
            return View(products);
        }
        //6
        public ActionResult AvgProductGame()
        {
            query = "SELECT p.Name, AVG(r.Rating) as avg " +
                "FROM bestbuy.products as p JOIN bestbuy.categories c " +
                "ON p.CategoryID = c.CategoryID LEFT JOIN bestbuy.reviews r " +
                "ON p.ProductID = r.ProductID WHERE c.Name = 'Games' " +
                "GROUP BY p.ProductID HAVING AVG(r.Rating) >= 4;";

            List<AvgProdGame> avgProdGames = new List<AvgProdGame>();

            using (var conn = _conn)
            {
                var adapter = new MySqlDataAdapter(query, (MySqlConnection)conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    AvgProdGame avgProdGame = new AvgProdGame();
                    avgProdGame.Name = row["Name"].ToString();
                    avgProdGame.Avg = double.Parse(row["avg"].ToString());
                    avgProdGames.Add(avgProdGame);
                }
            }
            return View(avgProdGames);
        }
        // 7
        public ActionResult SaleDepartmentQP()
        {
            query = "SELECT d.Name, SUM(s.Quantity * s.PricePerUnit) as sumqp " +
                "FROM bestbuy.departments as d JOIN bestbuy.categories as c " +
                "ON d.DepartmentID = c.DepartmentID JOIN bestbuy.products as p " +
                "ON c.CategoryID = p.CategoryID JOIN bestbuy.sales as s " +
                "ON p.ProductID = s.ProductID " +
                "WHERE s.Date >= '20190101' AND s.Date <= '20191231' " +
                "GROUP BY d.DepartmentID;";

            List<SaleDepartment> saleDepartments = new List<SaleDepartment>();

            using (var conn = _conn)
            {
                var adapter = new MySqlDataAdapter(query, (MySqlConnection)conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    SaleDepartment saleDepartment = new SaleDepartment();
                    saleDepartment.Name = row["Name"].ToString();
                    saleDepartment.SumQP = double.Parse(row["sumqp"].ToString());
                    saleDepartments.Add(saleDepartment);
                }
            }
            return View(saleDepartments);
        }
        // 8
        public ActionResult EmployeeBestSale()
        {
            query = "SELECT d.Name as DepartmentName, e.FirstName, e.LastName, e.Title " +
                "FROM bestbuy.departments as d JOIN bestbuy.categories as c " +
                "ON d.DepartmentID = c.DepartmentID JOIN bestbuy.products as p " +
                "ON c.CategoryID = p.CategoryID JOIN bestbuy.sales as s " +
                "ON p.ProductID = s.ProductID JOIN bestbuy.employees as e " +
                "ON s.EmployeeID = e.EmployeeID " +
                "WHERE s.Date >= '2018-01-01' and s.Date <= '2018-12-31' " +
                "ORDER BY d.Name, e.FirstName, e.LastName;";
            List<EmployeeSale> employeeSales = new List<EmployeeSale>();

            using (var conn = _conn)
            {
                var adapter = new MySqlDataAdapter(query, (MySqlConnection)conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    EmployeeSale employeeSale = new EmployeeSale();
                    employeeSale.DepartmentName = row["DepartmentName"].ToString();
                    employeeSale.FName = row["FirstName"].ToString();
                    employeeSale.LName = row["LastName"].ToString();
                    employeeSale.Title = row["Title"].ToString();
                    employeeSales.Add(employeeSale);
                }
            }
            return View(employeeSales);
        }
        // 9
        public ActionResult BestProductSale()
        {
            query = "SELECT Products.Name, SUM(Sales.Quantity * Sales.PricePerUnit) AS Revenue " +
                "FROM bestbuy.Products JOIN bestbuy.Sales " +
                "ON Products.ProductID = Sales.ProductID " +
                "GROUP BY Products.ProductID " +
                "ORDER BY Revenue DESC LIMIT 10;";
            List<BestProductSales> bestProductSales = new List<BestProductSales>();

            using (var conn = _conn)
            {
                var adapter = new MySqlDataAdapter(query, (MySqlConnection)conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    BestProductSales bestProductSale = new BestProductSales();

                    bestProductSale.PName = row["Name"].ToString();
                    bestProductSale.Price = double.Parse(row["Revenue"].ToString());
                    bestProductSales.Add(bestProductSale);
                }
            }
            return View(bestProductSales);
        }
    }
}
