using System.Collections.Generic;
using TvService.BusinessLayer.Abstract;
using TvService.DataAccessLayer.Abstract;
using TvService.EntityLayer.Concrete;

namespace TvService.BusinessLayer.Concrete
{
    public class ServiceRecordManager : IServiceRecordService
    {
        private readonly IServiceRecordDal _serviceRecordDal;

        public ServiceRecordManager(IServiceRecordDal serviceRecordDal)
        {
            _serviceRecordDal = serviceRecordDal;
        }

        public void TInsert(ServiceRecord serviceRecord)
        {
            _serviceRecordDal.Insert(serviceRecord);
        }

        public void TDelete(ServiceRecord serviceRecord)
        {
            _serviceRecordDal.Delete(serviceRecord);
        }

        public void TUpdate(ServiceRecord serviceRecord)
        {
            _serviceRecordDal.Update(serviceRecord);
        }

        public ServiceRecord TGetById(int id)
        {
            return _serviceRecordDal.GetById(id);
        }

        public List<ServiceRecord> TGetAll()
        {
            return _serviceRecordDal.GetAll();
        }
    }
}
