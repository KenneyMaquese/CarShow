using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aplication_Areas.EditarAutomoveis;
using Domain_Areas.Entidades;

namespace MvcApplication1.Controllers
{
    public class MeusAnunciosController : Controller
    {
        private MeusAnucios _meusAnucios;
        public MeusAnunciosController(MeusAnucios meusAnucios)
        {
            _meusAnucios = meusAnucios;
        }
        //
        // GET: /MeusAnuncios/

        public ActionResult Index(Cliente cliente)
        {
           var anuncios =  _meusAnucios.ListaAutomoveisDoCliente(cliente.ClienteId);
            return View(anuncios);
        }


        //[HttpPost]
        //public ActionResult Index()
        //{

        //    return View();
        //}

        //
        // GET: /MeusAnuncios/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /MeusAnuncios/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /MeusAnuncios/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /MeusAnuncios/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /MeusAnuncios/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /MeusAnuncios/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /MeusAnuncios/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
