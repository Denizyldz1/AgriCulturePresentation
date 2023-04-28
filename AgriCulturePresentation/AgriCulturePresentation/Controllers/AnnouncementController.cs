﻿using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriCulturePresentation.Controllers
{
    public class AnnouncementController : Controller
    {
        IAnnouncementService _announcementService;
        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService= announcementService;
        }
        public IActionResult Index()
        {
            var values = _announcementService.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAnnouncement() 
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(Announcement announcement)
        {
            announcement.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            announcement.Status = false;
            _announcementService.Insert(announcement);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcementService.GetById(id);
            _announcementService.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _announcementService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAnnouncement(Announcement announcement)
        {
            _announcementService.Update(announcement);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToTrue(int id)
        {
            _announcementService.AnnouncementStatusToTrue(id); 
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToFalse(int id)
        {
            _announcementService.AnnouncementStatusToFalse(id);
            return RedirectToAction("Index");
        }

    }
}
