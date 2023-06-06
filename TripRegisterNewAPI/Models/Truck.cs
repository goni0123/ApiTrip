using System.ComponentModel.DataAnnotations;

namespace TripRegisterNewAPI.Models
{
    public class Truck
    {
        [Key]
        public string? truck { get; set; }
    }
}
