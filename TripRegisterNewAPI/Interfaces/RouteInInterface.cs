using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Interfaces
{
    public interface RouteInInterface
    {
        bool CreateRouteIn(LastRoute lastRoute, RouteIn routeIn);
        bool Save();
    }
}
