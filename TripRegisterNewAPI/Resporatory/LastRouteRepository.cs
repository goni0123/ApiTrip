using TripRegisterNewAPI.Data;
using TripRegisterNewAPI.Interfaces;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Resporatory
{
    public class LastRouteRepository : LastRouteInterface
    {
        private readonly AppDBContext _context;
        public LastRouteRepository(AppDBContext context)
        {
            _context = context;
        }
        public LastRoute GetRoute(string trailor)
        {
            return _context.lastRoute.Where(r => r.Trailor == trailor).OrderBy(r => r.Last_route).FirstOrDefault();
        }

        public bool LastExists(string trailor)
        {
            return _context.lastRoute.Any(l => l.Trailor == trailor);
        }
    }
}
