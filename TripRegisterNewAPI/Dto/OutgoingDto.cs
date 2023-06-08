namespace TripRegisterNewAPI.Dto
{
    public class OutgoingDto
    {
        public int Nalog_nr { set; get; }
        public string? Truck { set; get; }
        public string? RIT { set; get; }
        public DateTime? Start_date { set; get; }
        public DateTime? End_date { set; get; }
        public int? KM { set; get; }
        public int? Work_days { set; get; }
        public string? Extra_Cost { set; get; }
        public string? Extra_Cost_Attachment { set; get; }
        public string? Invoice { set; get; }
        public string? Invoice_Attachment { set; get; }
        public string? Comment { set; get; }
        public string? Comment_Attachment { set; get; }
        public bool? Check { set; get; }
        public string? Driver { set; get; }
    }
}
