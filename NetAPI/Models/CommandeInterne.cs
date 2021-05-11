using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetAPI.Models
{
    public class CommandeInterne
    {
        public int Id { get; set; }
        public float PrixTotal { get; set; }
        public DateTime DateCommande { get; set; }
        public bool IsActive { get; set; }
        public string Statut { get; set; }
    }
}
