using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriCulturePresentation.ViewComponents.DefaultViewComponents
{
	public class _ImagePartial:ViewComponent
	{
		IImageService _imageService;

		public _ImagePartial(IImageService imageService)
		{
			_imageService = imageService;
		}

		public IViewComponentResult Invoke()
		{
			var values= _imageService.GetAll();
			return View(values);
		}
	}
}
