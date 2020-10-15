using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPI_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Season(int? temperature)
        {
            if (temperature == null) ViewBag.Temp = "Unknown";
            else ViewBag.Temp = temperature;
            ViewBag.Temp = temperature;


            if (temperature == null) ViewBag.Season = "Unknown";
            else
            {
                ExampleController controller = new ExampleController();
                ViewBag.Season = controller.GetSeason((int)temperature);
            }
                return View();
        }
    }
}
