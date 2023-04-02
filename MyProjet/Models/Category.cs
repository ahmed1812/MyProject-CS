using System.Collections.Generic;

namespace MyProjet.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

    }
}
