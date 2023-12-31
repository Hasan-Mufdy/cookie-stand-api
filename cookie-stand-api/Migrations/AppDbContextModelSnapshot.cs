﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cookie_stand_api.Data;

#nullable disable

namespace cookie_stand_api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Location = "amman",
                            Maximum_customers_per_hour = 20,
                            Minimum_customers_per_hour = 1,
                            Owner = "owner1"
                        });
                });

            modelBuilder.Entity("cookie_stand_api.Models.HourlySale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CookiestandId")
                        .HasColumnType("int");

                    b.Property<int>("Hour")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CookiestandId");

                    b.ToTable("HourlySales");
                });

            modelBuilder.Entity("cookie_stand_api.Models.HourlySale", b =>
                {
                    b.HasOne("cookie_stand_api.Models.Cookiestand", null)
                        .WithMany("HourlySales")
                        .HasForeignKey("CookiestandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("cookie_stand_api.Models.Cookiestand", b =>
                {
                    b.Navigation("HourlySales");
                });
#pragma warning restore 612, 618
        }
    }
}
