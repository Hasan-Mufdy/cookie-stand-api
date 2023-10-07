﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cookie_stand_api.Data;

#nullable disable

namespace cookie_stand_api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231005212735_latest")]
    partial class latest
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("cookie_stand_api.Models.Cookiestand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Average_cookies_per_sale")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HourlySales")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Maximum_customers_per_hour")
                        .HasColumnType("int");

                    b.Property<int>("Minimum_customers_per_hour")
                        .HasColumnType("int");

                    b.Property<string>("Owner")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cookiestands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Average_cookies_per_sale = 0.0,
                            Description = "desc",
                            HourlySales = "",
                            Location = "amman",
                            Maximum_customers_per_hour = 20,
                            Minimum_customers_per_hour = 1,
                            Owner = "owner1"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
