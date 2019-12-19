using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class BaseController : Controller
    {
        private List<y_UserPession> userPerssions = null;
        public BaseController()
        {
            userPerssions = WebDbContext.KaoshiDBEntities.y_Users
                .Where(x => x.Id == 1).FirstOrDefault()
                .y_UserPession.ToList();
            ViewBag.Perssions = userPerssions;
        }
    }
}