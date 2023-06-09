using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Interfaces
{
    public interface IncomingInterface
    {
        ICollection<Incoming> GetIncomings();
        Incoming GetIncoming(int id);
        bool IncomingExists(int id);
        ICollection<RouteIn> GetRouteById(int incomingid);
        ICollection<LoadingCompanyIn> GetLoadingById(int incomingid);
        bool CreateIncoming(Incoming incoming);
        bool CreateRouteIn  (RouteIn routeIn);
        bool CreateCompanyIn(LoadingCompanyIn loadingCompanyIn);
        bool Save();
    }
}
