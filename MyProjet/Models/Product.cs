using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyProjet.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public string OnSale { get; set; }
        public string StockLevel { get; set; }
    }
}
