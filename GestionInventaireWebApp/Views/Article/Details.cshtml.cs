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
    public class DetailsModel : PageModel
    {
        private readonly GestionInventaireWebApp.Models.BDD.NetContext _context;

        public DetailsModel(GestionInventaireWebApp.Models.BDD.NetContext context)
        {
            _context = context;
        }

        public Article Article { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Article = await _context.Articles.FirstOrDefaultAsync(m => m.Id == id);

            if (Article == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
