using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace cookie_stand_api.Models
{
    public class Cookiestand
    {

        public int Id { get; set; }
        public string Description { get; set; }

        public string Location { get; set; }

        //public List<HourlySale> hourly_sales { get; set; }
        public string HourlySales { get; set; }

        public int Minimum_customers_per_hour { get; set; }
        public int Maximum_customers_per_hour { get; set; }
        public double Average_cookies_per_sale { get; set; }

        public string? Owner { get; set; }

        //[NotMapped]
        //public List<int> HourlySales
        //{
        //    get => HourlySalesData.Split(',').Select(int.Parse).ToList();
        //    set => HourlySalesData = string.Join(',', value);
        //}

    }
}
