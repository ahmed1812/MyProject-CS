using System.Collections.Generic;

namespace MyProjet.Models
{
    public class ProductReviewVM
    {
        public int ProductID { get; set; }
        //public string Name { get; set; }
        //public double Price { get; set; }
        //public int CategoryID { get; set; }
        //public string OnSale { get; set; }
        //public string StockLevel { get; set; }
        public  Product products { get; set; }
        public int ReviewID { get; set; }
        //public string Reviewer { get; set; }
        //public string Comment { get; set; }
        //public int Rating { get; set; }
        public Review reviews { get; set; }
    }
}
