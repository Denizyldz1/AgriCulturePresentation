using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriCulturePresentation.ViewComponents.DefaultViewComponents
{
	public class _TeamPartial:ViewComponent
	{
		readonly ITeamService _teamService;

		public _TeamPartial(ITeamService teamService)
		{
			_teamService = teamService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _teamService.GetAll();
			return View(values);
		}
	}
}
