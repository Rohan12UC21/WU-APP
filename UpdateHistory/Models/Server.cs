using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UpdateHistory.Models
{
    public class Server
    {
        [Key]
        public int ID { get; set; }

        public int Index { get; set; }
        public bool isIt { get; set; }
        public string ServerName { get; set; }
        public string Location { get; set; }
        public string ICW { get; set; }
        public string WindowsVersion { get; set; }
        public string RealtimeVersion { get; set; }
        public bool Initiated { get; set; }
        public bool NoAccess { get; set; }
    }
}
