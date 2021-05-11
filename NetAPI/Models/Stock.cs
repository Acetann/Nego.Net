using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetAPI.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int QuantityCommande { get; set; }
        public ICollection<Article> Articles { get; set; }

        public ICollection<Order> Orders { get; set;}
     
    }
}
