using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriCulturePresentation.ViewComponents.DefaultViewComponents
{
	public class _AddressPartial:ViewComponent
	{
		IAddressService _addressService;

		public _AddressPartial(IAddressService addressService)
		{
			_addressService = addressService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _addressService.GetAll();
			return View(values);
		}
	}
}
