using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriCulturePresentation.ViewComponents.DefaultViewComponents
{
    public class _AnnouncementPartial : ViewComponent
    {
        readonly IAnnouncementService _announcementService;

        public _AnnouncementPartial(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _announcementService.GetAll();
            var newValues = new List<Announcement>();
            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].Status == true)
                {
                    newValues.Add(values[i]);
                }

            }
            return View(newValues);
        }
    }
}
