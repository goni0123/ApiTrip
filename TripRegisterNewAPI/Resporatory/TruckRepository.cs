using TripRegisterNewAPI.Data;
using TripRegisterNewAPI.Interfaces;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Resporatory
{
    public class TruckRepository:TruckInterface
    {
        private readonly AppDBContext _context;
        public TruckRepository(AppDBContext context)
        {
            _context = context;
        }
        public ICollection<Truck> GetTrucks()
        {
            return _context.trucks.OrderBy(t=>t.truck).ToList();
        }

        public Truck GetTruck(string truckid)
        {
            return _context.trucks.FirstOrDefault(t => t.truck== truckid);
        }

        public bool TruckExists(string truckid)
        {
            return _context.trucks.Any(t => t.truck == truckid);
        }
    }
}
