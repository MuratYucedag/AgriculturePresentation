using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAnnouncementService : IGenericService<Announcement>
    {
        void AnnouncementStatusToTrue(int id);
        void AnnouncementStatusToFalse(int id);   
    }
}
