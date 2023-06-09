using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Interfaces
{
    public interface TruckInterface
    {
        ICollection<Truck> GetTrucks();
        Truck GetTruck(string truckid);
        bool TruckExists(string truckid);
    }
}
