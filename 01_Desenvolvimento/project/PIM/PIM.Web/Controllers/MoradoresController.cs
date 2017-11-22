using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PIM.Database.DatabaseModel;

namespace PIM.Web.Controllers
{
    public class MoradoresController : Controller
    {
        private EntidadePIM db = new EntidadePIM();

        // GET: Moradores
        public ActionResult Index()
        {
            return View(db.Morador.ToList());
        }

        // GET: Moradores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Morador morador = db.Morador.Find(id);
            if (morador == null)
            {
                return HttpNotFound();
            }
            return View(morador);
        }

        // GET: Moradores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Moradores/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Identificador,Nome,RG,CPF,Telefone,Celular,DataNascimento,Email")] Morador morador)
        {
            if (ModelState.IsValid)
            {
                db.Morador.Add(morador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(morador);
        }

        // GET: Moradores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Morador morador = db.Morador.Find(id);
            if (morador == null)
            {
                return HttpNotFound();
            }
            return View(morador);
        }

        // POST: Moradores/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Identificador,Nome,RG,CPF,Telefone,Celular,DataNascimento,Email")] Morador morador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(morador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(morador);
        }

        // GET: Moradores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Morador morador = db.Morador.Find(id);
            if (morador == null)
            {
                return HttpNotFound();
            }
            return View(morador);
        }

        // POST: Moradores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Morador morador = db.Morador.Find(id);
            db.Morador.Remove(morador);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
