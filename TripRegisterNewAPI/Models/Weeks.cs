using System.ComponentModel.DataAnnotations;

namespace TripRegisterNewAPI.Models
{
    public class Weeks
    {
        [Key]
        public int ID { get; set; }
        public ICollection<Inland_week> inland_Week { get; set; }
        public ICollection<Inland_week_more> inland_Week_more { get; set; }
    }
}
