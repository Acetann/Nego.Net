using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionInventaireWebApp.Models.BDD
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
