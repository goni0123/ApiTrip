using System.ComponentModel.DataAnnotations;

namespace TripRegisterNewAPI.Models
{
    public class LoadingOrderIn
    {
        public string? AnAttn { get; set; }
        public string? VonFrom { get; set; }
        public string? Company1 { get; set; }
        public string? Company2 { get; set; }
        public string? Phone1Number { get; set; }
        public string? Phone2Number { get; set; }
        public string? Email { get; set; }
        [Key]
        public int LoadingOrderNumber { get; set; }
        public string? TruckPlate { get; set; }
        public string? DriverOrder { get; set; }
        public DateTime? LoadingDate { get; set; }
        public string? LoadingAddress { get; set; }
        public string? ExporterOrder { get; set; }
        public string? GoodsOrder { get; set; }
        public string? Packing { get; set; }
        public string? ByOrder { get; set; }
        public string? ImporterOrder { get; set; }
        public string? Offload { get; set; }
        public decimal? FreightPrice { get; set; }
        public string? FreightPaidBy { get; set; }
        public string? Notice { get; set; }
        public string? REFNumber { get; set; }
        public DateTime? DateDocument { get; set; }
        public bool? Check { get; set; }
    }
}
