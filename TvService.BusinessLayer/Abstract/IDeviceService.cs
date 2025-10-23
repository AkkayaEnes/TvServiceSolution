using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvService.EntityLayer.Concrete;

namespace TvService.BusinessLayer.Abstract
{
    internal interface IDeviceService
    {
        void TInsert(Device customer);
        void TDelete(Device customer);
        void TUpdate(Device customer);
        Device TGetById(int id);
        List<Device> TGetAll();
    }
}
