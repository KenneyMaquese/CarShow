using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Aplication_Areas.CadastroCliente;
using Domain_Areas.Entidades;

namespace MvcApplication1.Controllers
{
    public class LoguinController : Controller
    {
        private readonly LoguinDeCliente _loguinDeCliente;
        

        public LoguinController(LoguinDeCliente loguinDeCliente)
        {
            _loguinDeCliente = loguinDeCliente;
        }
        //
        // GET: /Loguin/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Loguin loguin)
        {
            try
            {
               loguin =  _loguinDeCliente.BuscarLoguin(loguin);
                
            }
            catch (Exception xException)
            {
                
            }
            if (_loguinDeCliente.Logado)
            {
                return RedirectToAction("Index", "MeusAnuncios",loguin.Clientes);
            }

            return View();
        }

        //
        // GET: /Loguin/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Loguin/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Loguin/Create

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
        // GET: /Loguin/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Loguin/Edit/5

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
        // GET: /Loguin/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Loguin/Delete/5

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
