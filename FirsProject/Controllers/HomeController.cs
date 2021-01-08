using FirsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirsProject.Controllers
{
    public class HomeController : Controller
    {
        PortfolioEntities db = new PortfolioEntities();
        public ActionResult Index()
        {
            ViewBag.section1 = db.Section1.First();
            ViewBag.section2 = db.Section2.First();
            ViewBag.section3 = db.Section3.ToList();
            ViewBag.section4 = db.Section4.ToList(); 
            ViewBag.section5 = db.Section5.ToList();
            ViewBag.section6 = db.Section6.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}