using TripRegisterNewAPI.Data;
using TripRegisterNewAPI.Interfaces;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Resporatory
{
    public class RouteInRepository : RouteInInterface
    {
        private readonly AppDBContext _context;
        public RouteInRepository(AppDBContext context)
        {
            _context = context;
        }
        public bool CreateRouteIn(LastRoute lastRoute, RouteIn routeIn)
        {
            lastRoute.City = routeIn.City;
            lastRoute.Trailor = routeIn.Trailor;

            _context.Add(routeIn);
            _context.Add(lastRoute);
            return Save();
        }
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false; 
        }
    }
}
