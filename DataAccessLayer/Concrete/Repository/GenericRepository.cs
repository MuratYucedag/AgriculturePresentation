using DataAccessLayer.Abstract;
using DataAccessLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        public void Delete(T t)
        {
            using var context = new AgricultureContext();
            context.Remove(t);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            using var context = new AgricultureContext();
            return context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var context = new AgricultureContext();
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var context = new AgricultureContext();
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            using var context = new AgricultureContext();
            context.Update(t);
            context.SaveChanges();
        }
    }
}
