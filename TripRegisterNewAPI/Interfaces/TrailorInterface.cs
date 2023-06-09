using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Interfaces
{
    public interface TrailorInterface
    {
        ICollection<Trailor> GetTrailors();
        Trailor GetTrailor(string trailorid);
        bool TrailorExists(string trailorid);
    }
}
