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
    public class DependentesController : Controller
    {
        private EntidadePIM db = new EntidadePIM();

        // GET: Dependentes
        public ActionResult Index()
        {
            var dependente = db.Dependente.Include(d => d.Morador);
            return View(dependente.ToList());
        }

        // GET: Dependentes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dependente dependente = db.Dependente.Find(id);
            if (dependente == null)
            {
                return HttpNotFound();
            }
            return View(dependente);
        }

        // GET: Dependentes/Create
        public ActionResult Create()
        {
            ViewBag.IdMorador = new SelectList(db.Morador, "Identificador", "Nome");
            return View();
        }

        // POST: Dependentes/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Identificador,Nome,RG,CPF,Telefone,IdMorador,GrauParentesco")] Dependente dependente)
        {
            if (ModelState.IsValid)
            {
                db.Dependente.Add(dependente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdMorador = new SelectList(db.Morador, "Identificador", "Nome", dependente.IdMorador);
            return View(dependente);
        }

        // GET: Dependentes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dependente dependente = db.Dependente.Find(id);
            if (dependente == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdMorador = new SelectList(db.Morador, "Identificador", "Nome", dependente.IdMorador);
            return View(dependente);
        }

        // POST: Dependentes/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Identificador,Nome,RG,CPF,Telefone,IdMorador,GrauParentesco")] Dependente dependente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dependente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdMorador = new SelectList(db.Morador, "Identificador", "Nome", dependente.IdMorador);
            return View(dependente);
        }

        // GET: Dependentes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dependente dependente = db.Dependente.Find(id);
            if (dependente == null)
            {
                return HttpNotFound();
            }
            return View(dependente);
        }

        // POST: Dependentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dependente dependente = db.Dependente.Find(id);
            db.Dependente.Remove(dependente);
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
