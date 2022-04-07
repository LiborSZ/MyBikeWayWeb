using Microsoft.EntityFrameworkCore;

namespace MyBikeWayWeb.Models.Data
{
    public class LocationContext: DbContext
    {
        public LocationContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Location> Locations { get; set; }
    }
}
