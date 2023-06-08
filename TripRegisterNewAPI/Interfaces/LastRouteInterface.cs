using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Interfaces
{
    public interface LastRouteInterface
    {
        LastRoute GetRoute(string trailor);
        bool LastExists(string trailor);
    }
}
