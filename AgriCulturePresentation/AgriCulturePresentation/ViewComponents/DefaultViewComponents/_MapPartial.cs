using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriCulturePresentation.ViewComponents.DefaultViewComponents
{
	public class _MapPartial:ViewComponent
	{
		AgriCultureContext _context;

		public _MapPartial(AgriCultureContext context)
		{
			_context = context;
		}

		public IViewComponentResult Invoke()
		{
			var values= _context.Addresses.Select(x=>x.MapInfo).FirstOrDefault();
			ViewBag.MapInfo=values;
			return View();
		}
	}
}
