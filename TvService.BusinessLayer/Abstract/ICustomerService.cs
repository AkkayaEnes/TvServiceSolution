using System;
using System.Collections.Generic;
using TvService.EntityLayer.Concrete;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvService.BusinessLayer.Abstract
{
    public interface ICustomerService
    {
        void TInsert(Customer customer);
        void TDelete(Customer customer);
        void TUpdate(Customer customer);
        Customer TGetById(int id);
        List<Customer> TGetAll();
    }
}
