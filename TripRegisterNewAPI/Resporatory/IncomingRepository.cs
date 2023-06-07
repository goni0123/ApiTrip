using TripRegisterNewAPI.Data;
using TripRegisterNewAPI.Interfaces;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Resporatory
{
    public class IncomingRepository:IncomingInterface
    {
        private readonly AppDBContext _context;
        public IncomingRepository(AppDBContext context)=>_context = context;
        public ICollection<Incoming> GetIncomings()
        {
            return _context.incoming.OrderBy(i=>i.Nalog_nr).ToList();
        }
        public Incoming GetIncoming(int id)
        {
            return _context.incoming.Where(i => i.Nalog_nr == id).FirstOrDefault();
        }
        public bool IncomingExists(int id)
        {
            return _context.incoming.Any(i=>i.Nalog_nr==id);
        }
    }
}
