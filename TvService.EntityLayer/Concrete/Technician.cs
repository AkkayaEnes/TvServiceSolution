using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvService.EntityLayer.Concrete
{
    public class Technician
    {
        public int TechnicianID { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public string Specialty { get; set; } // TV, Anakart, Ekran, Güç Kaynağı vs.

        // Atanan servisler
        public ICollection<ServiceRecord> ServiceRecords { get; set; }
    }
}

