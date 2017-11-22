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
    public class TipoReservasController : Controller
    {
        private EntidadePIM db = new EntidadePIM();

        // GET: TipoReservas
        public ActionResult Index()
        {
            return View(db.TipoReserva.ToList());
        }

        // GET: TipoReservas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoReserva tipoReserva = db.TipoReserva.Find(id);
            if (tipoReserva == null)
            {
                return HttpNotFound();
            }
            return View(tipoReserva);
        }

        // GET: TipoReservas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoReservas/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Identificador,Tipo")] TipoReserva tipoReserva)
        {
            if (ModelState.IsValid)
            {
                db.TipoReserva.Add(tipoReserva);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoReserva);
        }

        // GET: TipoReservas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoReserva tipoReserva = db.TipoReserva.Find(id);
            if (tipoReserva == null)
            {
                return HttpNotFound();
            }
            return View(tipoReserva);
        }

        // POST: TipoReservas/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Identificador,Tipo")] TipoReserva tipoReserva)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoReserva).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoReserva);
        }

        // GET: TipoReservas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoReserva tipoReserva = db.TipoReserva.Find(id);
            if (tipoReserva == null)
            {
                return HttpNotFound();
            }
            return View(tipoReserva);
        }

        // POST: TipoReservas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoReserva tipoReserva = db.TipoReserva.Find(id);
            db.TipoReserva.Remove(tipoReserva);
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
