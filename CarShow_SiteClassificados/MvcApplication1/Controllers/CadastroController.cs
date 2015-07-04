using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aplication_Areas.CadastroCliente;
using Domain_Areas.Entidades;

namespace MvcApplication1.Controllers
{
    public class CadastroController : Controller
    {
        private readonly CadastroCliente _cadastroCliente;
        public CadastroController(CadastroCliente cadastroCliente )
        {
            _cadastroCliente = cadastroCliente;
        }
        //
        // GET: /Cadastro/
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.TiposDeCliente = _cadastroCliente.CarregaTipoDeCliente();
            return View();
        }
        [HttpPost]
        public ActionResult Index(Loguin newloguin)
        {
            _cadastroCliente.AdicionarLoguin(newloguin);
            return View();
        }


        //
        // GET: /Cadastro/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Cadastro/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Cadastro/Create

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
        // GET: /Cadastro/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Cadastro/Edit/5

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
        // GET: /Cadastro/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Cadastro/Delete/5

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
