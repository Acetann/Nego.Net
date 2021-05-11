﻿// <auto-generated />
using System;
using GestionInventaireWebApp.Models.BDD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestionInventaireWebApp.Migrations
{
    [DbContext(typeof(NetContext))]
    partial class NetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BuyPrice")
                        .HasColumnType("int");

                    b.Property<int?>("CategorieId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProviderId")
                        .HasColumnType("int");

                    b.Property<int>("SellPrice")
                        .HasColumnType("int");

                    b.Property<int?>("StockId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategorieId");

                    b.HasIndex("ProviderId");

                    b.HasIndex("StockId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Categorie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderQuantity")
                        .HasColumnType("int");

                    b.Property<int?>("StockId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StockId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.OrderArticle", b =>
                {
                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("ArticleId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderArticles");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Article", b =>
                {
                    b.HasOne("GestionInventaireWebApp.Models.BDD.Categorie", "Categorie")
                        .WithMany("Articles")
                        .HasForeignKey("CategorieId");

                    b.HasOne("GestionInventaireWebApp.Models.BDD.Provider", "Provider")
                        .WithMany("Articles")
                        .HasForeignKey("ProviderId");

                    b.HasOne("GestionInventaireWebApp.Models.BDD.Stock", "Stock")
                        .WithMany("Articles")
                        .HasForeignKey("StockId");

                    b.Navigation("Categorie");

                    b.Navigation("Provider");

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Order", b =>
                {
                    b.HasOne("GestionInventaireWebApp.Models.BDD.Stock", "Stock")
                        .WithMany("Orders")
                        .HasForeignKey("StockId");

                    b.HasOne("GestionInventaireWebApp.Models.BDD.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");

                    b.Navigation("Stock");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.OrderArticle", b =>
                {
                    b.HasOne("GestionInventaireWebApp.Models.BDD.Article", "Article")
                        .WithMany("OrderArticles")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestionInventaireWebApp.Models.BDD.Order", "Order")
                        .WithMany("OrderArticles")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Article", b =>
                {
                    b.Navigation("OrderArticles");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Categorie", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Order", b =>
                {
                    b.Navigation("OrderArticles");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Provider", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.Stock", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("GestionInventaireWebApp.Models.BDD.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
