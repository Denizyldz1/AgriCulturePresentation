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
    public class EfImageDal : GenericRepository<Image>, IImageDal
    {
        public EfImageDal(AgriCultureContext context) : base(context)
        {
        }
    }
}
