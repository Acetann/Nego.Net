using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInventaireWinForms
{
    class CategorieDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isActive { get; set; }
    }

    class Datalist_Categorie
    {
        public List<ClientDTO> ListCategorie { get; set; }
    }
}
