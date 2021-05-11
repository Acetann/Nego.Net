using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderQuantity { get; set; } 

        public bool IsActive { get; set; }
        public User User { get; set; }
        public ICollection<OrderArticle> OrderArticles { get; set; }
        public Stock Stock { get; set; }


    }
}
