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
    public class VisitantesController : Controller
    {
        private EntidadePIM db = new EntidadePIM();

        // GET: Visitantes
        public ActionResult Index()
        {
            var visitante = db.Visitante.Include(v => v.Morador);
            return View(visitante.ToList());
        }

        // GET: Visitantes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visitante visitante = db.Visitante.Find(id);
            if (visitante == null)
            {
                return HttpNotFound();
            }
            return View(visitante);
        }

        // GET: Visitantes/Create
        public ActionResult Create()
        {
            ViewBag.IdMorador = new SelectList(db.Morador, "Identificador", "Nome");
            return View();
        }

        // POST: Visitantes/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Identificador,Nome,IdMorador")] Visitante visitante)
        {
            if (ModelState.IsValid)
            {
                db.Visitante.Add(visitante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdMorador = new SelectList(db.Morador, "Identificador", "Nome", visitante.IdMorador);
            return View(visitante);
        }

        // GET: Visitantes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visitante visitante = db.Visitante.Find(id);
            if (visitante == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdMorador = new SelectList(db.Morador, "Identificador", "Nome", visitante.IdMorador);
            return View(visitante);
        }

        // POST: Visitantes/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Identificador,Nome,IdMorador")] Visitante visitante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(visitante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdMorador = new SelectList(db.Morador, "Identificador", "Nome", visitante.IdMorador);
            return View(visitante);
        }

        // GET: Visitantes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visitante visitante = db.Visitante.Find(id);
            if (visitante == null)
            {
                return HttpNotFound();
            }
            return View(visitante);
        }

        // POST: Visitantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Visitante visitante = db.Visitante.Find(id);
            db.Visitante.Remove(visitante);
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
