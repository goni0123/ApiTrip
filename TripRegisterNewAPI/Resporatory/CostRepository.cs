using TripRegisterNewAPI.Data;
using TripRegisterNewAPI.Interfaces;
using TripRegisterNewAPI.Models;
namespace TripRegisterNewAPI.Resporatory
{
    public class CostRepository:CostInterface
    {
        private readonly AppDBContext _context;
        public CostRepository(AppDBContext context)
        {
            _context = context;
        }
        public ICollection<Cost> GetCosts()
        {
            return _context.costs.OrderBy(c => c.Nalog).ToList();
        }
        public Cost GetCost(int id)
        {
            return _context.costs.Where(c => c.Nalog == id).FirstOrDefault();
        }
        public bool CostExists(int id)
        {
            return _context.costs.Any(c => c.Nalog == id);
        }

        public bool CreateCost(Cost cost)
        {
            _context.Add(cost);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
