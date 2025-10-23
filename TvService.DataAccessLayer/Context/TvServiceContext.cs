using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using TvService.EntityLayer.Concrete;
using System.Data.Entity.SqlServer; // EF SQL provider’ını tanıtmak için

namespace TvService.DataAccessLayer.Context
{
    public class TvServiceContext : DbContext
    {
        // EF provider'ı elle kaydeder
        static TvServiceContext()
        {
            var ensureDLLIsCopied = SqlProviderServices.Instance;
        }

        public TvServiceContext() : base("name=TvServiceContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<ServiceRecord> ServiceRecords { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
