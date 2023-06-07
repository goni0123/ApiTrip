using System.ComponentModel.DataAnnotations;

namespace TripRegisterNewAPI.Models
{
    public class RouteOut
    {
        [Key]
        public int RO { get; set; }
        public string City { get; set; }
        public string Trailor { get; set; }
        public Outgoing Outgoing { get; set; }
    }
}
