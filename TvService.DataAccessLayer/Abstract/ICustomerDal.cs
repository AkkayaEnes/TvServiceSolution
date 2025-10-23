using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvService.DataAccessLayer.Repository;
using TvService.EntityLayer.Concrete;

namespace TvService.DataAccessLayer.Abstract
{
    public interface ICustomerDal : IGenericDal<Customer>
    {
    }
}