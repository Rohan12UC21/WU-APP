using System;
using System.ComponentModel.DataAnnotations;

namespace UpdateHistory.Models
{
    public class Info
    {
        [Key]
        public int ID { get; set; }

        public string updateID { get; set; }
        public string Title { get; set; }
        public string KBID { get; set; }
        public string MSRCSeverity { get; set; }
        public string MSRCNumber { get; set; }
        public string Classification { get; set; }
        public string Architecture { get; set; }
        public string SupportedProducts { get; set; }
        public string SupportedLanguages { get; set; }
        public string LastReleased { get; set; }
        public string UpdateStatus { get; set; }
        public string TestResults { get; set; }
        public string ICW { get; set; }
        public string Server { get; set; }
        public string Active { get; set; }


        [Display(Name = "Test Date")]
        [DataType(DataType.Date)]
        public DateTime TestDate { get; set; }

        [Display(Name = "Description")]
        public string Reason { get; set; }
    }
}
