using System.ComponentModel.DataAnnotations;

namespace TripRegisterNewAPI.Models
{
    public class Weeks
    {
        [Key]
        public int ID { get; set; }
        public ICollection<Inland_week> Inland_week { get; set; }

    }
}
