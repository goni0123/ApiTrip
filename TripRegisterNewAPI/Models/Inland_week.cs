using System.ComponentModel.DataAnnotations;

namespace TripRegisterNewAPI.Models
{
    public class Inland_week
    {
        [Key]
        public int? Nalog_nr { get; set; }
        public  string? Invoice { get; set; }
        public string? Invoice_Attachment { get; set;}
        public  bool? Check { get; set; }
        public ICollection<Inland_week_more> inland_Week_More { get; set; }
    }
}
