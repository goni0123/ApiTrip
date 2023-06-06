using Microsoft.EntityFrameworkCore;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Incoming> incoming { get; set; }
        public DbSet<Outgoing> outgoing { get; set; }
        public DbSet<LoadingCompanyIn> loadingCompanyIn { get; set; }
        public DbSet<LoadingCompanyOut> loadingCompanyOut { get; set; }
        public DbSet<RouteIn> routeIn { get; set; }
        public DbSet<RouteOut> routeOut { get; set; }
        public DbSet<LastRoute> lastRoute { get; set; }
        public DbSet<Inland_driving> inland_Driving { get; set; }
        public DbSet<Inland_driving_more> inland_Driving_More { get; set; }
        public DbSet<Weeks> weeks { get; set; }
        public DbSet<Inland_week> inland_week { get; set; }
        public DbSet<Inland_week_more> inland_week_more { get; set; }
        public DbSet<LoadingOrderIn> loadingOrderIn { get; set; }
        public DbSet<LoadingOrderOut> loadingOrderOut { get; set; }
        public DbSet<Truck> trucks { get; set; }
        public DbSet<Trailor> trailors { get; set; }
        public DbSet<Cost> costs { get; set; }
    }
}
