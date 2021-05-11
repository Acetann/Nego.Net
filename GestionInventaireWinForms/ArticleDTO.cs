using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInventaireWinForms
{
    class ArticleDTO
    {
        public int Id { get; set; }
        public long IdCategorie { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Domaine { get; set; }
        public string ImgUrl { get; set; }
        public string Volume { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
        public bool isActive { get; set; }
        public bool commandeAuto { get; set; }
    }

    class Datalist_Articles
    {
        public List<ArticleDTO> Listarticle { get; set; }
    }
}
