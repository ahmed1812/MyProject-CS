using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyProjet.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        public string Reviewer { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public int ProductID { get; set; }
        public List<ProductReviewVM> productReviewVMs { get; set; }
    }
}
