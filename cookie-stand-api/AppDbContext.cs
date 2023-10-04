using Microsoft.EntityFrameworkCore;

namespace cookie_stand_api
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
