using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Contexts;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Entity_Framework
{
    public class EfAnnouncementDal : GenericRepository<Announcement>, IAnnouncementDal
    {
        AgriCultureContext _context;
        public EfAnnouncementDal(AgriCultureContext context) : base(context)
        {
            _context = context;
        }

        public void AnnouncementStatusToFalse(int id)
        {
            Announcement p = _context.Announcements.Find(id);
            p.Status = false;
            _context.SaveChanges();
        }

        public void AnnouncementStatusToTrue(int id)
        {
            Announcement p = _context.Announcements.Find(id);
            p.Status = true;
            _context.SaveChanges();
        }
    }
}
