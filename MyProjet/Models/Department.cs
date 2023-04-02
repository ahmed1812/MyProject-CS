using System.Collections.Generic;

namespace MyProjet.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
    }
}
