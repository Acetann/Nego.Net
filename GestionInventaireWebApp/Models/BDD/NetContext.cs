using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionInventaireWebApp.Models.BDD
{
    public class NetContext : DbContext
    {
        public NetContext(DbContextOptions<NetContext> options)
    : base(options)
        { }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderArticle> OrderArticles { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderArticle>()
                .HasKey(o => new { o.ArticleId, o.OrderId });

            modelBuilder.Entity<User>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<Article>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<Provider>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<Stock>()
                .HasKey(a => a.Id);

        }
    }
}
