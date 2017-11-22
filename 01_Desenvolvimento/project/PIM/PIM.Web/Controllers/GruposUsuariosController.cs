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
    public class GruposUsuariosController : Controller
    {
        private EntidadePIM db = new EntidadePIM();

        // GET: GruposUsuarios
        public ActionResult Index()
        {
            return View(db.GrupoUsuario.ToList());
        }

        // GET: GruposUsuarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrupoUsuario grupoUsuario = db.GrupoUsuario.Find(id);
            if (grupoUsuario == null)
            {
                return HttpNotFound();
            }
            return View(grupoUsuario);
        }

        // GET: GruposUsuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GruposUsuarios/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Identificador,Nome")] GrupoUsuario grupoUsuario)
        {
            if (ModelState.IsValid)
            {
                db.GrupoUsuario.Add(grupoUsuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(grupoUsuario);
        }

        // GET: GruposUsuarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrupoUsuario grupoUsuario = db.GrupoUsuario.Find(id);
            if (grupoUsuario == null)
            {
                return HttpNotFound();
            }
            return View(grupoUsuario);
        }

        // POST: GruposUsuarios/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Identificador,Nome")] GrupoUsuario grupoUsuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(grupoUsuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(grupoUsuario);
        }

        // GET: GruposUsuarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrupoUsuario grupoUsuario = db.GrupoUsuario.Find(id);
            if (grupoUsuario == null)
            {
                return HttpNotFound();
            }
            return View(grupoUsuario);
        }

        // POST: GruposUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GrupoUsuario grupoUsuario = db.GrupoUsuario.Find(id);
            db.GrupoUsuario.Remove(grupoUsuario);
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
