using CvProject.Models.Entity;
using CvProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CvProject.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        ExperienceRepository experienceRepository = new ExperienceRepository();
        public ActionResult Index()
        {
            var degerler = experienceRepository.List();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]

        public ActionResult AddExperience(Experience experience)
        {
            experienceRepository.TAdd(experience);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteExperience(int id)
        {
            Experience experience = experienceRepository.Find(x => x.Id == id);
            experienceRepository.TRemove(experience);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateExperience(int id)
        {
            Experience experience = experienceRepository.Find(x => x.Id == id);
            return View(experience);
        }

        [HttpPost]
        public ActionResult UpdateExperience(Experience item)
        {
            Experience experience = experienceRepository.Find(x => x.Id == item.Id);
            experience.Subtitle = item.Subtitle;
            experience.Title = item.Title;
            experience.Description = item.Description;
            experience.Date = item.Date;
            experienceRepository.TUpdate(item);
            return RedirectToAction("Index");
        }
    }
}