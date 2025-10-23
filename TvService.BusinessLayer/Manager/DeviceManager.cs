using System.Collections.Generic;
using TvService.BusinessLayer.Abstract;
using TvService.DataAccessLayer.Abstract;
using TvService.EntityLayer.Concrete;

namespace TvService.BusinessLayer.Concrete
{
    public class DeviceManager : IDeviceService
    {
        private readonly IDeviceDal _deviceDal;

        public DeviceManager(IDeviceDal deviceDal)
        {
            _deviceDal = deviceDal;
        }

        public void TInsert(Device device)
        {
            _deviceDal.Insert(device);
        }

        public void TDelete(Device device)
        {
            _deviceDal.Delete(device);
        }

        public void TUpdate(Device device)
        {
            _deviceDal.Update(device);
        }

        public Device TGetById(int id)
        {
            return _deviceDal.GetById(id);
        }

        public List<Device> TGetAll()
        {
            return _deviceDal.GetAll();
        }
    }
}
