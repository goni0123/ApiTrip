using TripRegisterNewAPI.Data;
using TripRegisterNewAPI.Interfaces;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Resporatory
{
    public class IncomingRepository:IncomingInterface
    {
        private readonly AppDBContext _context;
        public IncomingRepository(AppDBContext context)=>_context = context;
        public ICollection<Incoming> GetIncoming()
        {
            return _context.incoming.OrderBy(i=>i.Nalog_nr).ToList();
        }
    }
}
