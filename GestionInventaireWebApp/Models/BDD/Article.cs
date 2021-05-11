using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionInventaireWebApp.Models.BDD
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
        public Provider Provider { get; set; }
        public Categorie Categorie { get; set; }
        public ICollection<OrderArticle> OrderArticles { get; set; }
        public Stock Stock { get; set; }
    }
}
