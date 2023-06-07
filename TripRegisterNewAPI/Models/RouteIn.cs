using System.ComponentModel.DataAnnotations;

namespace TripRegisterNewAPI.Models
{
    public class RouteIn
    {
        [Key]
        public int RI { get; set; }
        public string City_in { get; set; }
        public string Trailor_in { get; set; }
        public Incoming Incoming { get; set; }
    }
}
