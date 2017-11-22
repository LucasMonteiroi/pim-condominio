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
    public class ReservasController : Controller
    {
        private EntidadePIM db = new EntidadePIM();

        // GET: Reservas
        public ActionResult Index()
        {
            var reserva = db.Reserva.Include(r => r.Moradores).Include(r => r.TipoReserva);
            return View(reserva.ToList());
        }

        // GET: Reservas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reserva reserva = db.Reserva.Find(id);
            if (reserva == null)
            {
                return HttpNotFound();
            }
            return View(reserva);
        }

        // GET: Reservas/Create
        public ActionResult Create()
        {
            ViewBag.IdMorador = new SelectList(db.Morador, "Identificador", "Nome");
            ViewBag.IdTipoReserva = new SelectList(db.TipoReserva, "Identificador", "Tipo");
            return View();
        }

        // POST: Reservas/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Identificador,DataReserva,IdTipoReserva,ConfirmacaoReserva,IdMorador")] Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                db.Reserva.Add(reserva);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdMorador = new SelectList(db.Morador, "Identificador", "Nome", reserva.IdMorador);
            ViewBag.IdTipoReserva = new SelectList(db.TipoReserva, "Identificador", "Tipo", reserva.IdTipoReserva);
            return View(reserva);
        }

        // GET: Reservas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reserva reserva = db.Reserva.Find(id);
            if (reserva == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdMorador = new SelectList(db.Morador, "Identificador", "Nome", reserva.IdMorador);
            ViewBag.IdTipoReserva = new SelectList(db.TipoReserva, "Identificador", "Tipo", reserva.IdTipoReserva);
            return View(reserva);
        }

        // POST: Reservas/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Identificador,DataReserva,IdTipoReserva,ConfirmacaoReserva,IdMorador")] Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reserva).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdMorador = new SelectList(db.Morador, "Identificador", "Nome", reserva.IdMorador);
            ViewBag.IdTipoReserva = new SelectList(db.TipoReserva, "Identificador", "Tipo", reserva.IdTipoReserva);
            return View(reserva);
        }

        // GET: Reservas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reserva reserva = db.Reserva.Find(id);
            if (reserva == null)
            {
                return HttpNotFound();
            }
            return View(reserva);
        }

        // POST: Reservas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reserva reserva = db.Reserva.Find(id);
            db.Reserva.Remove(reserva);
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
