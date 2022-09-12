using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void Delete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public Service GetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public List<Service> GetListAll()
        {
            return _serviceDal.GetListAll();
        }

        public void Insert(Service t)
        {
            _serviceDal.Insert(t);
        }

        public void Update(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}
