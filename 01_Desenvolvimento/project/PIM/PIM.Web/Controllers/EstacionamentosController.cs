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
    public class EstacionamentosController : Controller
    {
        private EntidadePIM db = new EntidadePIM();

        // GET: Estacionamentos
        public ActionResult Index()
        {
            var estacionamento = db.Estacionamento.Include(e => e.Apartamento);
            return View(estacionamento.ToList());
        }

        // GET: Estacionamentos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estacionamento estacionamento = db.Estacionamento.Find(id);
            if (estacionamento == null)
            {
                return HttpNotFound();
            }
            return View(estacionamento);
        }

        // GET: Estacionamentos/Create
        public ActionResult Create()
        {
            ViewBag.IdApartamento = new SelectList(db.Apartamento, "Identificador", "Numero");
            return View();
        }

        // POST: Estacionamentos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Identificador,VagasDisponiveis,IdApartamento")] Estacionamento estacionamento)
        {
            if (ModelState.IsValid)
            {
                db.Estacionamento.Add(estacionamento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdApartamento = new SelectList(db.Apartamento, "Identificador", "Numero", estacionamento.IdApartamento);
            return View(estacionamento);
        }

        // GET: Estacionamentos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estacionamento estacionamento = db.Estacionamento.Find(id);
            if (estacionamento == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdApartamento = new SelectList(db.Apartamento, "Identificador", "Numero", estacionamento.IdApartamento);
            return View(estacionamento);
        }

        // POST: Estacionamentos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Identificador,VagasDisponiveis,IdApartamento")] Estacionamento estacionamento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estacionamento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdApartamento = new SelectList(db.Apartamento, "Identificador", "Numero", estacionamento.IdApartamento);
            return View(estacionamento);
        }

        // GET: Estacionamentos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estacionamento estacionamento = db.Estacionamento.Find(id);
            if (estacionamento == null)
            {
                return HttpNotFound();
            }
            return View(estacionamento);
        }

        // POST: Estacionamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Estacionamento estacionamento = db.Estacionamento.Find(id);
            db.Estacionamento.Remove(estacionamento);
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
