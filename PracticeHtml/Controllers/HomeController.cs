using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticeHtml.Repository;
using PracticeHtml.Models;

namespace PracticeHtml.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var studentmethod = new StudentExpenses();
            var studentEarnings = studentmethod.CalculateEarnings();

            //var display = new Display();
            //display.Earnings = 50M;

            var displaymethod = new Display();
            displaymethod.Earnings = 50M;
            var fullPath = displaymethod.GetFullPath("Martina", "Martina");

            return View(displaymethod);
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