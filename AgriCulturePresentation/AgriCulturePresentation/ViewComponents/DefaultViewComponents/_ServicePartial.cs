using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriCulturePresentation.ViewComponents.DefaultViewComponents
{
	public class _ServicePartial:ViewComponent
	{
		IServiceService _serviceService;

		public _ServicePartial(IServiceService serviceService)
		{
			_serviceService = serviceService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _serviceService.GetAll();
			return View(values);
		}
	}
}
