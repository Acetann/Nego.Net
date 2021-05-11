using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetAPI.Models
{
    public class CommandeInterneArticle
    {
        public long Id { get; set; }
        public int IdCommandeInterne { get; set; }
        public int IdProduit { get; set; }
        public int Quantite { get; set; }
    }
}
