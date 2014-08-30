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
                InsertContact(model.Nom, model.Email, model.Commentaires);
                TempData["notice"] = "Soumis avec succès";
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        private void InsertContact(string name, string email, string comments)
        {
            // code pour conserver le contact, mais pas requis pour l'exercice...
        }
    }
}
