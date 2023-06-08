using Microsoft.EntityFrameworkCore;
using TripRegisterNewAPI.Data;
using TripRegisterNewAPI.Interfaces;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Resporatory
{
    public class LoadingOrderInRepository:LoadingOrderInInterface
    {
        private readonly AppDBContext _context;
        public LoadingOrderInRepository(AppDBContext context)
        {
            _context = context;
        }

        public LoadingOrderIn GetOrder(int id)
        {
            return _context.loadingOrderIn.Where(l=>l.LoadingOrderNumber==id).FirstOrDefault();
        }

        public ICollection<LoadingOrderIn> GetOrders()
        {
            return _context.loadingOrderIn.ToList();
        }

        public bool OrderExists(int id)
        {
            return _context.loadingOrderIn.Any(l => l.LoadingOrderNumber == id);
        }
    }
}
