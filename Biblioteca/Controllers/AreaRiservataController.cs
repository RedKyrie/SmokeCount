using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Biblioteca.Models.Entity;

namespace Biblioteca.Controllers
{
    public class AreaRiservataController : Controller
    {
        // GET: AreaRiservata
        public ActionResult Index()
        {
            var utente = (Utente)Session["UtenteLoggato"];
            if (utente == null)
                return RedirectToAction("Login", "Account");
            return View();
        }
    }
}