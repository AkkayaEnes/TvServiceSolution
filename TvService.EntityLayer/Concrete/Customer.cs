using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvService.EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        // İlişkiler
        public ICollection<Device> Devices { get; set; }
    }
}
