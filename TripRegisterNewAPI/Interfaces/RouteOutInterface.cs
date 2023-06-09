using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Interfaces
{
    public interface RouteOutInterface
    {
        bool CreateRouteIn(RouteOut routeOut);
        bool Save();
    }
}
