using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInventaireWinForms
{
    class CommandeInterneDTO
    {
        public long id { get; set; }
        public long prixTotal { get; set; }
        public bool isActive { get; set; }
        public string dateCommande { get; set; }
        public string statut { get; set; }

    }


    class Datalist_Commande_Interne
    {
        public List<CommandeInterneDTO> ListcommandeInterne { get; set; }
    }
}
