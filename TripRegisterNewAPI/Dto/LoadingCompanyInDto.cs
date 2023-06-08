using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Dto
{
    public class LoadingCompanyInDto
    {
        public string? Export { get; set; }
        public string? Importer { get; set; }
        public int? Colli { get; set; }
        public decimal? KG { get; set; }
        public string? Document { get; set; }
        public string? Transport_Invoice { get; set; }
    }
}
