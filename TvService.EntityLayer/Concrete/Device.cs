using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvService.EntityLayer.Concrete
{
    public class Device
    {
        public int DeviceID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string ProblemDescription { get; set; }
        public string Status { get; set; } // Beklemede, Tamirde, Teslim Edildi

        // Foreign Key
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        // Servis kayıtları
        public ICollection<ServiceRecord> ServiceRecords { get; set; }
    }
}
