using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Interfaces
{
    public interface InlandInterface
    {
        ICollection<Inland_driving> GetInlands();
        Inland_driving GetInland(int id);
        bool InlandExists(int id);
        ICollection<Inland_driving_more> GetInlandMoreById(int inlandid);
    }
}
