using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetAPI.Models;

namespace NetAPI.Data
{
    public class NetApiContext : DbContext
    {
        public NetApiContext(DbContextOptions<NetApiContext> options)
            : base(options)
        {
        }

        public DbSet<NetAPI.Models.User> Client { get; set; }

        public DbSet<NetAPI.Models.Order> Commande { get; set; }

        public DbSet<NetAPI.Models.Categorie> Categorie { get; set; }

        public DbSet<NetAPI.Models.Provider> Fournisseur { get; set; }

        public DbSet<NetAPI.Models.Article> Article { get; set; }

        public DbSet<NetAPI.Models.Stock> Stock { get; set; }

        public DbSet<NetAPI.Models.CommandeInterne> CommandeInterne { get; set; }

        public DbSet<NetAPI.Models.CommandeInterneArticle> CommandeInterneArticle { get; set; }

        public DbSet<NetAPI.Models.OrderArticle> CommandeArticle { get; set; }

        public DbSet<NetAPI.Models.ProviderArticle> ProduitFournisseur { get; set; }
    }
    class Datalist_Article
    {
        public List<Article> Listarticle { get; set; }
    }
}
