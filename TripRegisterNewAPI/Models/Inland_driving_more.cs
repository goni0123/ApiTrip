using System.ComponentModel.DataAnnotations;

namespace TripRegisterNewAPI.Models
{
    public class Inland_driving_more
    {
        [Key]
        public int ID{ get; set; }
        public DateTime? Date { get; set; }
        public int? KM { get; set; }
        public string? Trailor { get; set; }
        public string? Truck { get; set; }
        public string? City { get; set; }
        public Inland_driving Inland { get; set; }
    }
}
