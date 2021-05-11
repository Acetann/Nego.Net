using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetAPI.Models
{
    public class OrderArticle
    {
        public int OrderId { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public Order Order { get; set; }
    }
}
