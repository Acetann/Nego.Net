using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetAPI.Models
{
    public class ProviderArticle
    {
        public long Id { get; set; }
        public int IdArticle { get; set; }
        public int IdFournisseur { get; set; }
    }
}
