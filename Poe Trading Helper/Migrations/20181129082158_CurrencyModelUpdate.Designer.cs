﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PoeTradingHelper.Backend.DAL;

namespace PoeTradingHelper.Migrations
{
    [DbContext(typeof(TradingContext))]
    [Migration("20181129082158_CurrencyModelUpdate")]
    partial class CurrencyModelUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PoeTradingHelper.Backend.Models.Currency", b =>
                {
                    b.Property<int>("PoeNinjaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IconUrl");

                    b.Property<string>("Name");

                    b.HasKey("PoeNinjaId");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("PoeTradingHelper.Backend.Models.CurrencyRatio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("GetAmount");

                    b.Property<int?>("GetInGameId");

                    b.Property<float>("PayAmount");

                    b.Property<int?>("PayInGameId");

                    b.HasKey("Id");

                    b.HasIndex("GetInGameId");

                    b.HasIndex("PayInGameId");

                    b.ToTable("CurrencyRatios");
                });

            modelBuilder.Entity("PoeTradingHelper.Backend.Models.DivinationCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CardsPerSet");

                    b.Property<string>("FlavorText");

                    b.Property<int>("InGameId");

                    b.Property<string>("Name");

                    b.Property<int?>("PriceId");

                    b.HasKey("Id");

                    b.HasIndex("PriceId");

                    b.ToTable("DivinationCards");
                });

            modelBuilder.Entity("PoeTradingHelper.Backend.Models.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("PriceInChaos");

                    b.Property<float>("PriceInExalted");

                    b.HasKey("Id");

                    b.ToTable("Price");
                });

            modelBuilder.Entity("PoeTradingHelper.Backend.Models.CurrencyRatio", b =>
                {
                    b.HasOne("PoeTradingHelper.Backend.Models.Currency", "Get")
                        .WithMany()
                        .HasForeignKey("GetInGameId");

                    b.HasOne("PoeTradingHelper.Backend.Models.Currency", "Pay")
                        .WithMany()
                        .HasForeignKey("PayInGameId");
                });

            modelBuilder.Entity("PoeTradingHelper.Backend.Models.DivinationCard", b =>
                {
                    b.HasOne("PoeTradingHelper.Backend.Models.Price", "Price")
                        .WithMany()
                        .HasForeignKey("PriceId");
                });
#pragma warning restore 612, 618
        }
    }
}
