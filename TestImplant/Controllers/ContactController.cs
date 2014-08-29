using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestImplant.Models;

namespace TestImplant.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        [HttpGet]
        public ActionResult ContactForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ContactForm(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                InsertContact(model.Name, model.Email, model.Comments);
                TempData["notice"] = "submitted successfully";
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        private void InsertContact(string name, string email, string comments)
        {
            
        }
    }
}
