using System.Collections.Generic;
using TvService.BusinessLayer.Abstract;
using TvService.DataAccessLayer.Abstract;
using TvService.EntityLayer.Concrete;

namespace TvService.BusinessLayer.Concrete
{
    public class TechnicianManager : ITechnicianService
    {
        private readonly ITechnicianDal _technicianDal;

        public TechnicianManager(ITechnicianDal technicianDal)
        {
            _technicianDal = technicianDal;
        }

        public void TInsert(Technician technician)
        {
            _technicianDal.Insert(technician);
        }

        public void TDelete(Technician technician)
        {
            _technicianDal.Delete(technician);
        }

        public void TUpdate(Technician technician)
        {
            _technicianDal.Update(technician);
        }

        public Technician TGetById(int id)
        {
            return _technicianDal.GetById(id);
        }

        public List<Technician> TGetAll()
        {
            return _technicianDal.GetAll();
        }
    }
}
