using MyProjet.Models;
using System.Collections.Generic;

namespace MyProjet.Data.Entity
{
    public interface ISaleRepo
    {
        public IEnumerable<Sale> GetAllSales();
        public Sale GetSale(int id);
        public void UpdateSale(Sale sale);
        public void InsertSale(Sale saleToInsert);
        public IEnumerable<Employee> GetEmployees();
        public IEnumerable<Product> GetProducts();
        public Sale AssignAll();
        public void DeleteSale(Sale sale);
    }
}
