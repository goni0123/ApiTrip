using System.ComponentModel.DataAnnotations;

namespace TripRegisterNewAPI.Models
{
    public class RouteIn
    {
        [Key]
        public int RI { get; set; }
        public string City { get; set; }
        public string Trailor { get; set; }
        public Incoming Incoming { get; set; }
    }
}
