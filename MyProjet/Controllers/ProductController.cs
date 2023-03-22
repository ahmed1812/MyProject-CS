﻿using Dapper;
using Microsoft.AspNetCore.Mvc;
using MyProjet.Data;
using MyProjet.Models;
using System.Data;
using System.Linq;

namespace MyProjet.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repo;
        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var products = repo.GetAllProducts();
            return View(products);
        }
        public IActionResult ViewProduct(int id)
        {
            
            var product = repo.GetProduct(id);

            return View(product);
        }
        public IActionResult UpdateProduct(int id)
        {
            Product prod = repo.GetProduct(id);

            if (prod == null)
            {
                return View("ProductNotFound");
            }

            return View(prod);
        }
        public IActionResult UpdateProductToDatabase(Product product)
        {
            repo.UpdateProduct(product);

            return RedirectToAction("ViewProduct", new { id = product.ProductID });
        }
        public IActionResult InsertProduct()
        {
            var prod = repo.AssignCategory();

            return View(prod);
        }
        public IActionResult InsertProductToDatabase(Product productToInsert)
        {
            repo.InsertProduct(productToInsert);

            return RedirectToAction("Index");
        }
        public IActionResult DeleteProduct(Product product)
        {
            repo.DeleteProduct(product);

            return RedirectToAction("Index");
        }

    }
}