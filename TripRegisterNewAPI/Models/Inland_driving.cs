using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace TripRegisterNewAPI.Models
{
    public class Inland_driving
    {
        [Key]
        public int Nalog_nr { set; get; }
        public string Invoice{ get; set; }
        public string Invoice_Attachment { get; set; }
        public bool Check { get; set; }
        public ICollection<Inland_driving_more> inland_Driving_More { get; set; }
    }
}
