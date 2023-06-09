using TripRegisterNewAPI.Data;
using TripRegisterNewAPI.Interfaces;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Resporatory
{
    public class WeekRepository : WeekInterface
    {
        private readonly AppDBContext _context;
        public WeekRepository(AppDBContext context)
        {
            _context = context;
        }
        public ICollection<Inland_week> GetInlandById(int weekid)
        {
            return _context.inland_week.Where(iw=>iw.Weeks.ID==weekid).OrderBy(iw=>iw.Nalog_nr).ToList();
        }

        public Weeks GetWeek(int id)
        {
            return _context.weeks.Where(w => w.ID == id).FirstOrDefault();
        }

        public ICollection<Weeks> GetWeeks()
        {
            return _context.weeks.ToList();
        }

        public bool WeekExists(int id)
        {
            return _context.weeks.Any(w=> w.ID == id);
        }
     
        public ICollection<Inland_week_more> GetWeekMores(int weekid)
        {
            return _context.inland_week_more.Where(i=>i.inland_Week.Weeks.ID==weekid).ToList();
        }
    }
}
