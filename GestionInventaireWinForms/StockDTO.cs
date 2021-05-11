using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInventaireWinForms
{
    class StockDTO
    {
        public int Id { get; set; }

        public int IdArticle { get; set; }
        public int Quantity { get; set; }
        public int QuantityCommande { get; set; }
    }

    class Datalist_Stock
    {
        public List<StockDTO> ListStock { get; set; }
    }
}

