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
    public class OcorrenciasController : Controller
    {
        private EntidadePIM db = new EntidadePIM();

        // GET: Ocorrencias
        public ActionResult Index()
        {
            var ocorrencia = db.Ocorrencia.Include(o => o.Morador);
            return View(ocorrencia.ToList());
        }

        // GET: Ocorrencias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ocorrencia ocorrencia = db.Ocorrencia.Find(id);
            if (ocorrencia == null)
            {
                return HttpNotFound();
            }
            return View(ocorrencia);
        }

        // GET: Ocorrencias/Create
        public ActionResult Create()
        {
            ViewBag.IdMorador = new SelectList(db.Morador, "Identificador", "Nome");
            return View();
        }

        // POST: Ocorrencias/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Identificador,Motivo,Descricao,DataOcorrencia,IdMorador")] Ocorrencia ocorrencia)
        {
            if (ModelState.IsValid)
            {
                db.Ocorrencia.Add(ocorrencia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdMorador = new SelectList(db.Morador, "Identificador", "Nome", ocorrencia.IdMorador);
            return View(ocorrencia);
        }

        // GET: Ocorrencias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ocorrencia ocorrencia = db.Ocorrencia.Find(id);
            if (ocorrencia == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdMorador = new SelectList(db.Morador, "Identificador", "Nome", ocorrencia.IdMorador);
            return View(ocorrencia);
        }

        // POST: Ocorrencias/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Identificador,Motivo,Descricao,DataOcorrencia,IdMorador")] Ocorrencia ocorrencia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ocorrencia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdMorador = new SelectList(db.Morador, "Identificador", "Nome", ocorrencia.IdMorador);
            return View(ocorrencia);
        }

        // GET: Ocorrencias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ocorrencia ocorrencia = db.Ocorrencia.Find(id);
            if (ocorrencia == null)
            {
                return HttpNotFound();
            }
            return View(ocorrencia);
        }

        // POST: Ocorrencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ocorrencia ocorrencia = db.Ocorrencia.Find(id);
            db.Ocorrencia.Remove(ocorrencia);
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
