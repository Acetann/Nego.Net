using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GestionInventaireWebApp.Models.BDD;

namespace GestionInventaireWebApp.Views
{
    public class IndexModel : PageModel
    {
        private readonly GestionInventaireWebApp.Models.BDD.NetContext _context;

        public IndexModel(GestionInventaireWebApp.Models.BDD.NetContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; }

        public async Task OnGetAsync()
        {
            Article = await _context.Articles.ToListAsync();
        }
    }
}
