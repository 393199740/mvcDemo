using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.App_Start
{
    public class PessionAuthAttribute : ActionFilterAttribute
    {
        protected string pessionCode { get; set; }

        public PessionAuthAttribute(string pessionCode)
        {
            this.pessionCode = pessionCode;
        }


        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //if (WebDbContext.KaoshiDBEntities.y_Users.FirstOrDefault(x => x.Id == 2)
            //    .y_UserPession.Count(x => x.PerssionCode == pessionCode) <= 0)
            //{
            //    //filterContext.Result = new RedirectToRouteResult(
            //    //    new System.Web.Routing.RouteValueDictionary(new {

            //    //    }));
            //    filterContext.HttpContext.Response.Redirect("/Login/Index", true);
            //}
            base.OnActionExecuting(filterContext);
        }
    }
}