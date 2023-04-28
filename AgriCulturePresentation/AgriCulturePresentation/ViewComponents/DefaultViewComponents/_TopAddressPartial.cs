using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriCulturePresentation.ViewComponents.DefaultViewComponents
{
	public class _TopAddressPartial:ViewComponent
	{
		IAddressService _addressService;

		public _TopAddressPartial(IAddressService addressService)
		{
			_addressService = addressService;
		}

		public IViewComponentResult Invoke()
		{
			var values= _addressService.GetAll();
			return View(values);
		}
	}
}
