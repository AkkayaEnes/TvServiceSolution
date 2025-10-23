using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using TvService.EntityLayer.Concrete;

namespace TvService.DataAccessLayer.Context
{
    public class TvServiceContext : DbContext
    {
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
