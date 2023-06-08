using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Interfaces
{
    public interface LoadingOrderOutInterface
    {
        ICollection<LoadingOrderOut> Getorders();
        LoadingOrderOut GetOrder(int id);
        bool OrderExits(int id);
    }
}
