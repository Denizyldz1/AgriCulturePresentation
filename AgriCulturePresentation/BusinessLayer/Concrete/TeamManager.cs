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
    public class TeamManager : ITeamService
    {
        ITeamDal _teamDal;
        public TeamManager(ITeamDal teamDal)
        {
            _teamDal=teamDal;
        }
        public void Delete(Team t)
        {
           _teamDal.Delete(t);
        }

        public List<Team> GetAll()
        {
            return _teamDal.GetAll();
        }

        public Team GetById(int id)
        {
            return _teamDal.GetById(id);
        }

        public void Insert(Team t)
        {
            _teamDal.Insert(t);
        }

        public void Update(Team t)
        {
            _teamDal.Update(t);
        }
    }
}