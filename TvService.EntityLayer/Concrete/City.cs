using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvService.EntityLayer.Concrete
{
    public class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }

        public ICollection<Customer> Customers { get; set; }
        public ICollection<Technician> Technicians { get; set; }
    }
}

