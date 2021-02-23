using Biblioteca.Helpers;
using Biblioteca.Models.Entity;
using Biblioteca.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biblioteca.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]  //dice che è una get
        public ActionResult Index()  //usa le query che vengono caricate e le manda nel View.Index
        {
            List<Pacchetto> pachetti = DatabaseHelper.GetAllPacchetti();
            var model = new IndexViewModel
            {
                Pacchetti = pachetti
            };
            return View(model);
        }

        [HttpGet]
        public ActionResult Detail(int id)  //usa le query che vengono caricate e le manda nel View.Detail
        {
            var pacchetto = DatabaseHelper.GetPacchettoById(id);
            //prodotto.Immagine = PathHelper.GetProdottoImagePath(prodotto);
            var model = new DetailViewModel
            {
                Pacchetto = pacchetto
            };
            if (pacchetto == null)
            {
                model.MessaggioErrore = "Prodotto non esistente";
                ViewBag.Title = "Errore";
            }
            else
            {
                ViewBag.Title = pacchetto.Nome;
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult HomePage()
        {
            var model = new HomeViewModel();
            return View(model);
        }
    }
}