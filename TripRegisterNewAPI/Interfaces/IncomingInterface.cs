using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Interfaces
{
    public interface IncomingInterface
    {
        ICollection<Incoming> GetIncoming();
    }
}
