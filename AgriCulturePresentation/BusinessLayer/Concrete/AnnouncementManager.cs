﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal=announcementDal;
        }

        public void AnnouncementStatusToFalse(int id)
        {
            _announcementDal.AnnouncementStatusToFalse(id);
        }

        public void AnnouncementStatusToTrue(int id)
        {
            _announcementDal.AnnouncementStatusToTrue(id);
        }

        public void Delete(Announcement t)
        {
            
            _announcementDal.Delete(t);
        }

        public List<Announcement> GetAll()
        {
          return _announcementDal.GetAll();
        }

        public Announcement GetById(int id)
        {
          return  _announcementDal.GetById(id);
        }

        public void Insert(Announcement t)
        {
            _announcementDal.Insert(t);
        }

        public void Update(Announcement t)
        {
            _announcementDal.Update(t);
        }
    }
}
