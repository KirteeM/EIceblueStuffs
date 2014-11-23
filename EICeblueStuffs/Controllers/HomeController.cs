using EIceblueStuffs.ICeblueHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EICeblueStuffs.Controllers
{
    public class HomeController : Controller
    {
        SpireExcel spireExcel = new SpireExcel();
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            spireExcel.CreateSampleExcel(); //Create a sample
            spireExcel.ConvertToPDF(); //Convert to pdf

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
