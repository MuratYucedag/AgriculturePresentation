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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Delete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public Contact GetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> GetListAll()
        {
            return _contactDal.GetListAll();
        }

        public void Insert(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void Update(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
