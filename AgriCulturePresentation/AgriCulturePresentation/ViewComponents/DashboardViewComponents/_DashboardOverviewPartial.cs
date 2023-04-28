
using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _DashboardOverviewPartial : ViewComponent
    {
        AgriCultureContext _context;

        public _DashboardOverviewPartial(AgriCultureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.teamCount = _context.Teams.Count();
            ViewBag.serviceCount = _context.Services.Count();
            ViewBag.messageCount = _context.Contacts.Count();
            ViewBag.currentMonthMessage = 3;

            ViewBag.announcementTrue = _context.Announcements.Where(x => x.Status == true).Count();
            ViewBag.announcementFalse = _context.Announcements.Where(x => x.Status == false).Count();

            ViewBag.urunPazarlama = _context.Teams.Where(x => x.Title == "Ürün Pazarlama").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.bakliyatYonetimi = _context.Teams.Where(x => x.Title == "Bakliyat Yönetimi").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.sutUretici = _context.Teams.Where(x => x.Title == "Süt Üreticisi").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.gubreYonetimi = _context.Teams.Where(x => x.Title == "Gübre Yönetimi").Select(y => y.PersonName).FirstOrDefault();
            return View();
        }
    }
}
