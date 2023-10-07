using cookie_stand_api.Data;
using cookie_stand_api.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace cookie_stand_api.Models.Services
{
    public class CookiestandService : ICookiestand
    {
        private readonly AppDbContext _context;

        public CookiestandService(AppDbContext context)
        {
            _context = context;
        }

        public async Task Delete(int id)
        {
            var cookieStand = await _context.Cookiestands.SingleOrDefaultAsync(c => c.Id == id);
            _context.Cookiestands.Remove(cookieStand);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Cookiestand>> GetAll()
        {
            var cookieStand = await _context.Cookiestands.ToListAsync();
            return cookieStand;
        }

        public async Task<Cookiestand> GetById(int id)
        {
            var cookieStand = await _context.Cookiestands.SingleOrDefaultAsync(c => c.Id == id);
            return cookieStand;
        }

        public async Task<Cookiestand> Post(Cookiestand newCookieStand)
        {
            var cookieStand = new Cookiestand()
            {
                // Id = cookiestand.Id,
                Description = newCookieStand.Description,
                Location = newCookieStand.Location,
                HourlySales = newCookieStand.HourlySales,
                Minimum_customers_per_hour = newCookieStand.Minimum_customers_per_hour,
                Maximum_customers_per_hour = newCookieStand.Maximum_customers_per_hour,
                Average_cookies_per_sale = newCookieStand.Average_cookies_per_sale,//((newCookieStand.Minimum_customers_per_hour + newCookieStand.Maximum_customers_per_hour) / 2),//cookiestand.Average_cookies_per_sale,
                Owner = newCookieStand.Owner
            };
            await _context.Cookiestands.AddAsync(cookieStand);
            await _context.SaveChangesAsync();
            return newCookieStand;
        }

        public async Task<Cookiestand> Put(int id, Cookiestand newCookiestand)
        {
            var cookieStand = await _context.Cookiestands.SingleOrDefaultAsync(c => c.Id == id);
            cookieStand.Description = newCookiestand.Description;
            cookieStand.Location = newCookiestand.Location;
            cookieStand.HourlySales = newCookiestand.HourlySales;
            cookieStand.Minimum_customers_per_hour = newCookiestand.Minimum_customers_per_hour;
            cookieStand.Maximum_customers_per_hour = newCookiestand.Maximum_customers_per_hour;
            cookieStand.Average_cookies_per_sale = newCookiestand.Average_cookies_per_sale;
            cookieStand.Owner = newCookiestand.Owner;

            await _context.SaveChangesAsync();
            return newCookiestand;

        }
        //public async Task UpdateHourlySales(int id, List<int> hourlySales)
        //{
        //    var cookieStand = await _context.Cookiestands.SingleOrDefaultAsync(c => c.Id == id);
        //    if (cookieStand != null)
        //    {
        //        cookieStand.HourlySales = hourlySales;
        //        await _context.SaveChangesAsync();
        //    }
        //}


    }
}
