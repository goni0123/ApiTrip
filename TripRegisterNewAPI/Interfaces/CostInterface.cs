using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Interfaces
{
    public interface CostInterface
    {
        ICollection<Cost> GetCosts();
        Cost GetCost(int id);
        bool CostExists(int id);
    }
}
