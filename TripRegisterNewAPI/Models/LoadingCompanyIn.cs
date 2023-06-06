using System.ComponentModel.DataAnnotations;

namespace TripRegisterNewAPI.Models
{
    public class LoadingCompanyIn
    {
        [Key]
        public int LCI { get; set; }
        public string Export { get; set; }
        public string Importer { get; set; }
        public int Colli { get; set; }
        public decimal KG { get; set; }
        public string Document { get; set; }
        public string Transport_Invoice { get; set; }
    }
}
