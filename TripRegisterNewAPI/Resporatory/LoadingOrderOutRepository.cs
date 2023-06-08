using TripRegisterNewAPI.Data;
using TripRegisterNewAPI.Interfaces;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Resporatory
{
    public class LoadingOrderOutRepository : LoadingOrderOutInterface
    {
        private readonly AppDBContext _context;
        public LoadingOrderOutRepository(AppDBContext context)
        {
            _context = context;
        }

        public LoadingOrderOut GetOrder(int id)
        {
            return _context.loadingOrderOut.Where(o => o.LoadingOrderNumber == id).FirstOrDefault();
        }

        public ICollection<LoadingOrderOut> Getorders()
        {
            return _context.loadingOrderOut.ToList();
        }

        public bool OrderExits(int id)
        {
            return _context.loadingOrderOut.Any(o=>o.LoadingOrderNumber==id);
        }
    }
}
