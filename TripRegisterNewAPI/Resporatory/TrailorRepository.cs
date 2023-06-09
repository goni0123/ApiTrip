using TripRegisterNewAPI.Data;
using TripRegisterNewAPI.Interfaces;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Resporatory
{
    public class TrailorRepository:TrailorInterface
    {
        private readonly AppDBContext _context;
        public TrailorRepository(AppDBContext context)
        {
            _context = context;
        }
        public ICollection<Trailor> GetTrailors()
        {
            return _context.trailors.ToList();
        }

        public Trailor GetTrailor(string trailorid)
        {
            return _context.trailors.FirstOrDefault(t => t.trailor== trailorid);
        }

        public bool TrailorExists(string trailorid)
        {
            return _context.trailors.Any(t => t.trailor == trailorid);
        }
    }
}
