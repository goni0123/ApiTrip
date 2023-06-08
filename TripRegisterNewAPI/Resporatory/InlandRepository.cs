using Microsoft.EntityFrameworkCore;
using TripRegisterNewAPI.Data;
using TripRegisterNewAPI.Interfaces;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Resporatory
{
    public class InlandRepository : InlandInterface
    {
        private readonly AppDBContext _context;
        public InlandRepository(AppDBContext context)
        {
            _context = context;
        }
        public Inland_driving GetInland(int id)
        {
            return _context.inland_Driving.Where(i => i.Nalog_nr == id).FirstOrDefault();
        }

        public ICollection<Inland_driving_more> GetInlandMoreById(int inlandid)
        {
            return _context.inland_Driving_More.Where(iw => iw.Inland.Nalog_nr== inlandid).ToList();
        }

        public ICollection<Inland_driving> GetInlands()
        {
            return _context.inland_Driving.ToList();
        }


        public bool InlandExists(int id)
        {
            return _context.inland_week.Any(i => i.Nalog_nr == id);
        }
    }
}

