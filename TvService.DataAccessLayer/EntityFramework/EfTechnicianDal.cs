using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvService.DataAccessLayer.Abstract;
using TvService.DataAccessLayer.Repository;
using TvService.EntityLayer.Concrete;

namespace TvService.DataAccessLayer.EntityFramework
{
    internal class EfTechnicianDal:GenericRepository<Technician>, ITechnicianDal
    {
    }
}
