using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestImplant.Models;

namespace TestImplant.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index(string order)
        {
            var model = new TestModel();

            if (order != "dystopia")
            {
                model.MessageMod = "For democracy";
            }
            else
            {
                model.MessageMod = "All hail the emperor!";
            }

            ViewData["messageView"] = "allo tout le monde (ViewData)";
            ViewBag.Message = "Bonjournos (baggies)";
            return View(model);
        }

    }
}
