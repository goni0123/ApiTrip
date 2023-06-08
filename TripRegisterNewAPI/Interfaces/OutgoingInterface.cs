using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Interfaces
{
    public interface OutgoingInterface
    {
        ICollection<Outgoing> GetOutgoings();
        Outgoing GetOutgoing(int id);
        bool OutgoingExists(int id);
        ICollection<RouteOut> GetRouteById(int outgoingid);
        ICollection<LoadingCompanyOut> GetLoadingById(int outgoingid);
    }
}
