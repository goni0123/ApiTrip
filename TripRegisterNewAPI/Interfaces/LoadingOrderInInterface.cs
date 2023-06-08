using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Interfaces
{
    public interface LoadingOrderInInterface
    {
        ICollection<LoadingOrderIn> GetOrders();
        LoadingOrderIn GetOrder(int id);
        bool OrderExists(int id);
    }
}
