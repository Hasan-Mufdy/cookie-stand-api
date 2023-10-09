using cookie_stand_api.Models;
using Microsoft.EntityFrameworkCore;

namespace cookie_stand_api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Cookiestand> Cookiestands { get; set; }
        public DbSet<HourlySale> HourlySales { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cookiestand>()
            .HasKey(c => c.Id);

            //modelBuilder.Entity<HourlySale>()
            //.HasKey(h => h.Id);

            //modelBuilder.Entity<HourlySale>()
            //.HasOne(h => h.Cookiestand)
            //.WithMany(c => c.HourlySales)
            //.HasForeignKey(h => h.CookiestandId);


            //        modelBuilder.Entity<Cookiestand>()
            //.HasKey(c => c.Id);
            //        modelBuilder.Entity<Cookiestand>().HasData(
            //            new Cookiestand { Id = 1, Description = "desc", Location = "amman", HourlySales = { }, Minimum_customers_per_hour = 1, Maximum_customers_per_hour = 20, Average_cookies_per_sale = 0, Owner = "owner1", HourlySalesData = "10,15,20,25,30,35,40,45,50,55,60,65" }
            //        );


            modelBuilder.Entity<Cookiestand>().HasData(
            new Cookiestand { Id = 1, Description = "desc", Location = "amman", Minimum_customers_per_hour = 1, Maximum_customers_per_hour = 20, Average_cookies_per_sale = 0, Owner = "owner1" }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
