using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvService.EntityLayer.Concrete;

namespace TvService.BusinessLayer.Abstract
{
    internal interface ITechnicianService
    {
        void TInsert(Technician customer);
        void TDelete(Technician customer);
        void TUpdate(Technician customer);
        Technician TGetById(int id);
        List<Technician> TGetAll();
    }
}
