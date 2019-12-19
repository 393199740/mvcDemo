using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.App_Start;

namespace Web.Controllers
{
    public class HomeController : BaseController
    {
        [PessionAuth("1001")]
        public ActionResult Index()
        {
            var model = WebDbContext.KaoshiDBEntities.y_Users.ToList();

            return View(model);
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