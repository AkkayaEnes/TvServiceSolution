using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvService.BusinessLayer.Abstract;
using TvService.DataAccessLayer.Abstract;
using TvService.EntityLayer.Concrete;

namespace TvService.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        // Dependency Injection: hangi DAL kullanılacaksa buradan alınır
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TInsert(Customer customer)
        {
            _customerDal.Insert(customer);
        }

        public void TDelete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public void TUpdate(Customer customer)
        {
            _customerDal.Update(customer);
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public List<Customer> TGetAll()
        {
            return _customerDal.GetAll();
        }
    }
}
