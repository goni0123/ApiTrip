using System.ComponentModel.DataAnnotations;

namespace TripRegisterNewAPI.Models
{
    public class LastRoute
    {
        [Key]
        public int Last_route { get; set; }
        [Required]
        public  string City { get; set; }
        [Required]
        public string Trailor{ get; set; }
    }
}
