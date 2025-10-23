using System;

namespace TvService.EntityLayer.Concrete
{
    public class ServiceRecord
    {
        public int ServiceRecordID { get; set; }
        public DateTime ReceivedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string OperationsDone { get; set; }
        public decimal Cost { get; set; }

        // Foreign Keys
        public int DeviceID { get; set; }
        public Device Device { get; set; }

        public int TechnicianID { get; set; }
        public Technician Technician { get; set; }
    }
}