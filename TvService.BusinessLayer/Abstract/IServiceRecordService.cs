using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvService.EntityLayer.Concrete;

namespace TvService.BusinessLayer.Abstract
{
    internal interface IServiceRecordService
    {
        void TInsert(ServiceRecord customer);
        void TDelete(ServiceRecord customer);
        void TUpdate(ServiceRecord customer);
        ServiceRecord TGetById(int id);
        List<ServiceRecord> TGetAll();
    }
}
