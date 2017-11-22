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
    public class AdvertenciasController : Controller
    {
        private EntidadePIM db = new EntidadePIM();

        // GET: Advertencias
        public ActionResult Index()
        {
            var advertencia = db.Advertencia.Include(a => a.Ocorrencia);
            return View(advertencia.ToList());
        }

        // GET: Advertencias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advertencia advertencia = db.Advertencia.Find(id);
            if (advertencia == null)
            {
                return HttpNotFound();
            }
            return View(advertencia);
        }

        // GET: Advertencias/Create
        public ActionResult Create()
        {
            ViewBag.IdOcorrencia = new SelectList(db.Ocorrencia, "Identificador", "Motivo");
            return View();
        }

        // POST: Advertencias/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Identificador,Valor,Pago,IdOcorrencia")] Advertencia advertencia)
        {
            if (ModelState.IsValid)
            {
                db.Advertencia.Add(advertencia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdOcorrencia = new SelectList(db.Ocorrencia, "Identificador", "Motivo", advertencia.IdOcorrencia);
            return View(advertencia);
        }

        // GET: Advertencias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advertencia advertencia = db.Advertencia.Find(id);
            if (advertencia == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdOcorrencia = new SelectList(db.Ocorrencia, "Identificador", "Motivo", advertencia.IdOcorrencia);
            return View(advertencia);
        }

        // POST: Advertencias/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Identificador,Valor,Pago,IdOcorrencia")] Advertencia advertencia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(advertencia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdOcorrencia = new SelectList(db.Ocorrencia, "Identificador", "Motivo", advertencia.IdOcorrencia);
            return View(advertencia);
        }

        // GET: Advertencias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advertencia advertencia = db.Advertencia.Find(id);
            if (advertencia == null)
            {
                return HttpNotFound();
            }
            return View(advertencia);
        }

        // POST: Advertencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Advertencia advertencia = db.Advertencia.Find(id);
            db.Advertencia.Remove(advertencia);
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
