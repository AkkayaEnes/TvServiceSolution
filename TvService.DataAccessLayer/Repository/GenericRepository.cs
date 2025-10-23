using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvService.DataAccessLayer.Context;

namespace TvService.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        TvServiceContext context = new TvServiceContext(); //Veritabanıyla konuşmaya hazırım.
        DbSet<T> _object; //Hangi tabloyla çalışacağımı belirliyor.

        public GenericRepository()
        {
            _object = context.Set<T>(); //Mesela parametre olarak Customer verdiysem context.Customers'a karşılık gelecek. Sınıf çalıştığında, hangi tabloyla çalışacağını belirliyor.
        }

        public void Insert(T entity)
        {
            _object.Add(entity); //Ekleme işlemi
            context.SaveChanges(); //Değişiklikleri kaydet
        }

        public void Delete(T entity)
        {
            _object.Remove(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }
    }
}
