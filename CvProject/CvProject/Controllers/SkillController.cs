using CvProject.Models.Entity;
using CvProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CvProject.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        GenericRepository<Skill> repository = new GenericRepository<Skill>();
        public ActionResult Index()
        {
            var yetenekler = repository.List();
            return View();
        }
    }
}