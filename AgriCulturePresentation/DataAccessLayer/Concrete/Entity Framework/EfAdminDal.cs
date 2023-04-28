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
	public class EfAdminDal : GenericRepository<Admin>, IAdminDal
	{
		public EfAdminDal(AgriCultureContext context) : base(context)
		{
		}
	}
}
