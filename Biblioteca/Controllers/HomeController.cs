﻿using Biblioteca.Helpers;
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
        [HttpGet]
        public ActionResult Index()
        {
            var model = new IndexViewModel();
            return View(model);
        }

        // GET: Home
        [HttpGet]  //dice che è una get
        public ActionResult Pacchetti()  //usa le query che vengono caricate e le manda nel View.Pacchetti
        {
            List<Pacchetto> pachetti = DatabaseHelper.GetAllPacchetti();
            var model = new PacchettiViewModel
            {
                Pacchetti = pachetti
            };
            return View(model);
        }

        [HttpGet]  //dice che è una get
        public ActionResult PacchettiRiservata()  //usa le query che vengono caricate e le manda nel View.Pacchetti
        {
            List<Pacchetto> pachetti = DatabaseHelper.GetAllPacchetti();
            var model = new PacchettiViewModel
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
        public ActionResult DetailHeets(int id)  //usa le query che vengono caricate e le manda nel View.Detail
        {
            var heets = DatabaseHelper.GetHeetsById(id);
            //prodotto.Immagine = PathHelper.GetProdottoImagePath(prodotto);
            var model = new DetailHeetsViewModel
            {
                Heets = heets
            };
            if (heets == null)
            {
                model.MessaggioErrore = "Prodotto non esistente";
                ViewBag.Title = "Errore";
            }
            else
            {
                ViewBag.Title = heets.Nome;
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult HomePage()
        {
            var model = new HomeViewModel();
            return View(model);
        }

        [HttpGet]
        public ActionResult Tipologie()
        {
            var model = new TipologieViewModel();
            return View(model);
        }

        [HttpGet]
        public ActionResult TipologieRiservata()
        {
            var model = new TipologieViewModel();
            return View(model);
        }

        [HttpGet]  //dice che è una get
        public ActionResult Heets()  //usa le query che vengono caricate e le manda nel View.Pacchetti
        {
            List<Heetss> heets = DatabaseHelper.GetAllHeets();
            var model = new HeetsViewModel
            {
                Heets = heets
            };
            return View(model);
        }

        [HttpGet]  //dice che è una get
        public ActionResult Tabacco()  //usa le query che vengono caricate e le manda nel View.Pacchetti
        {
            List<Tabacco> trinciato = DatabaseHelper.GetAllTabacco();
            var model = new TabaccoViewModel
            {
                Trinciato = trinciato
            };
            return View(model);
        }

        [HttpGet]
        public ActionResult DetailTabacco(int id)  //usa le query che vengono caricate e le manda nel View.Detail
        {
            var trinciato = DatabaseHelper.GetTabaccoById(id);
            //prodotto.Immagine = PathHelper.GetProdottoImagePath(prodotto);
            var model = new DetailTabaccoViewModel
            {
                Trinciato = trinciato
            };
            if (trinciato == null)
            {
                model.MessaggioErrore = "Prodotto non esistente";
                ViewBag.Title = "Errore";
            }
            else
            {
                ViewBag.Title = trinciato.Nome;
            }
            return View(model);
        }

    }
}