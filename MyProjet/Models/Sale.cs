using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace MyProjet.Models
{
    public class Sale
    {
        public int SalesID { get; set; }
        public string ProductID { get; set; }
        public string Quantity { get; set; }
        public double PricePerUnit { get; set; }
        public DateTime Date { get; set; }
        public int EmployeeID { get; set; }
        public IEnumerable<Employee> employees { get; set; }
        public IEnumerable<Product> products { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

    }
}
