using System.ComponentModel.DataAnnotations;
using System.Data;

namespace TripRegisterNewAPI.Models
{
    public class Inland_week_more
    {
        [Key]
        public int ID { get; set; }
        public DateTime Data { get; set; }
        public int KM{ get; set; }
        public string Trailor { get; set; }
        public string Truck { get; set; }
        public string City { get; set; }

    }
}
