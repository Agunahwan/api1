using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace API1.Controllers
{
    public class HomeController : Controller
    {
        public void Index()
        {
            //ViewBag.Title = "Home Page";

            //return View();
            Response.Redirect("~/Swagger");
        }
    }
}
