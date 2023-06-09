using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Interfaces
{
    public interface WeekInterface
    {
        ICollection<Weeks> GetWeeks();
        Weeks GetWeek(int id);
        ICollection<Inland_week> GetInlandById(int weekid);
        bool WeekExists(int id);
        ICollection<Inland_week_more> GetWeekMores(int weekid);
    }
}
