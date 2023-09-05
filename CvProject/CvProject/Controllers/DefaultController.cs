using CvProject.Models.Entity;
using System;
using System.Linq;
using System.Web.Mvc;

namespace CvProject.Controllers
{
    public class DefaultController : Controller
    {
        CvProjectEntities context = new CvProjectEntities();

        public ActionResult Index()
        {
            var degerler = context.About.ToList();
            return View(degerler);
        }
        public PartialViewResult Experience()
        {
            var experience = context.Experience.ToList();
            return PartialView(experience);
        }
        public PartialViewResult Education()
        {

            var education = context.Education.ToList();

            return PartialView(education);
        }
        public PartialViewResult Skill()
        {

            var skill = context.Skill.ToList();

            return PartialView(skill);
        }
        public PartialViewResult Interest()
        {

            var ınterests = context.Interst.ToList();

            return PartialView(ınterests);
        }
        public PartialViewResult Certificate()
        {

            var certificates = context.Award.ToList();

            return PartialView(certificates);
        }
        [HttpGet]
        public PartialViewResult Communication()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Communication(Communication comminacition)
        {
            comminacition.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            context.Communication.Add(comminacition);
            context.SaveChanges();
            return PartialView();
        }
    }
}