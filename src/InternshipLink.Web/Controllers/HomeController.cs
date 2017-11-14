using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InternshipLink.Web.Models;

namespace InternshipLink.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return new ViewResult(); //View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Test = true;

            var model = new AboutViewModel();
            model.MyName = "Velio";

            return View(model);
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel model)
        {
            if(ModelState.IsValid)
            {
                string name = model.Name;
                // TODO
            }

            return View(model);
        }
    }
}