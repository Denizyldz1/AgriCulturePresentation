using Microsoft.AspNetCore.Mvc;

namespace AgriCulturePresentation.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
