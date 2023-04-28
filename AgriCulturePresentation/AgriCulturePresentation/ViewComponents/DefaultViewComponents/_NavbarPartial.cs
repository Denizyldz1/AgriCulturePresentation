using Microsoft.AspNetCore.Mvc;

namespace AgriCulturePresentation.ViewComponents.DefaultViewComponents
{
	public class _NavbarPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
