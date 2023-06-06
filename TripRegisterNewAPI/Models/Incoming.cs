using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.ComponentModel.DataAnnotations;

namespace TripRegisterNewAPI.Models
{
    public class Incoming
    {
        [Key]
        public int Nalog_nr { set; get; }
        public string Truck { set; get; }
        public string RIT { set; get; }
        public DateTime Start_date { set; get; }
        public DateTime End_date { set; get; }
        public int KM { set; get; }
        public int Work_days { set; get; }
        public string Extra_Cost { set; get; }
        public string Extra_Cost_Attachment { set; get; }
        public string Invoice { set; get; }
        public string Invoice_Attachment { set; get; }
        public string Comment { set; get; }
        public string Comment_Attachment { set; get; }
        public bool Check { set; get; }
        public string Driver { set; get; }
        public ICollection<LoadingCompanyIn> LoadingCompanyIn { get; set; }
        public ICollection<RouteIn> routeIn { set; get; }

    }
}
