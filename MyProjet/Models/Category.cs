using System.Collections.Generic;
using MyProjet.Models;

namespace MyProjet.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public IEnumerable<Department> Departments {get; set;}
        public List<Product> Products { get; set; } = new List<Product>();

    }
}
