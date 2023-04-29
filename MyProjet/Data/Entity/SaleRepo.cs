using Dapper;
using Microsoft.CodeAnalysis;
using MyProjet.Models;
using System.Collections.Generic;
using System.Data;

namespace MyProjet.Data.Entity
{
    public class SaleRepo : ISaleRepo
    {
        private readonly IDbConnection _conn;
        public SaleRepo(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Sale> GetAllSales()
        {
            return _conn.Query<Sale>("SELECT * FROM Sales;");
        }
        public Sale GetSale(int id)
        {
            return _conn.QuerySingle<Sale>("SELECT * FROM Sales WHERE SaleID = @id",
               new { id });
        }
        //SalesID, ProductID, Quantity, PricePerUnit, Date, EmployeeID
        public void UpdateSale(Sale sale)
        {
            _conn.Execute("UPDATE Sales SET Quantity = @quantity, PricePerUnit = @pricePerUnit, Date = @date WHERE SaleID = @id",
                new { quantity = sale.Quantity, pricePerUnit = sale.PricePerUnit, Date = sale.Date, id = sale.SalesID });
        }
        public void InsertSale(Sale saleToInsert)
        {
            _conn.Execute("INSERT INTO Sales (ProductID, Quantity, PricePerUnit, Date, EmployeeID) VALUES (@productID, @quantity, @pricePerUnit, @date, @employeeID);",
                new { productID = saleToInsert.ProductID, quantity = saleToInsert.Quantity, pricePerUnit = saleToInsert.PricePerUnit, date = saleToInsert.Date, employeeID = saleToInsert.EmployeeID });
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _conn.Query<Employee>("SELECT * FROM Employees;");
        }
        public IEnumerable<Product> GetProducts()
        {
            return _conn.Query<Product>("SELECT * FROM Products;");
        }
        public Sale AssignAll()
        {
            var empList = GetEmployees();
            var prudList = GetProducts();
            var sale = new Sale();
            sale.employees = empList;
            sale.products = prudList;

            return sale;
        }
        public void DeleteSale(Sale sale)
        {
            _conn.Execute("DELETE FROM Sales WHERE SaleID = @id;",
                                       new { id = sale.SalesID });
        }
    }
}
