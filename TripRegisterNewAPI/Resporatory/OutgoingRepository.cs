using TripRegisterNewAPI.Data;
using TripRegisterNewAPI.Interfaces;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Resporatory
{
    public class OutgoingRepository : OutgoingInterface
    {
        private readonly AppDBContext _context;
        public OutgoingRepository(AppDBContext context)
        {
            _context = context;
        }
        public ICollection<LoadingCompanyOut> GetLoadingById(int outgoingid)
        {
            return _context.loadingCompanyOut.OrderBy(l => l.Outgoing.Nalog_nr == outgoingid).ToList();
        }

        public Outgoing GetOutgoing(int id)
        {
            return _context.outgoing.Where(o=>o.Nalog_nr==id).FirstOrDefault() ?? null;
        }

        public ICollection<Outgoing> GetOutgoings()
        {
            return _context.outgoing.OrderBy(o => o.Nalog_nr).ToList();
        }

        public ICollection<RouteOut> GetRouteById(int outgoingid)
        {
            return _context.routeOut.OrderBy(r=>r.Outgoing.Nalog_nr==outgoingid).ToList();     
        }

        public bool OutgoingExists(int id)
        {
            return _context.outgoing.Any(o=>o.Nalog_nr == id);
        }
    }
}
