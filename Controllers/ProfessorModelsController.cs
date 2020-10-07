using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CAD_Prof.Context;
using CAD_Prof.Models;

namespace CAD_Prof.Controllers
{
    public class ProfessorModelsController : Controller
    {
        private Contexto db = new Contexto();

        // GET: ProfessorModels
        public ActionResult Index()
        {
            return View(db.Professores.ToList());
        }

        // GET: ProfessorModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfessorModel professorModel = db.Professores.Find(id);
            if (professorModel == null)
            {
                return HttpNotFound();
            }
            return View(professorModel);
        }

        // GET: ProfessorModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProfessorModels/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Endereco,Telefone,Email,Disciplina")] ProfessorModel professorModel)
        {
            if (ModelState.IsValid)
            {
                db.Professores.Add(professorModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(professorModel);
        }

        // GET: ProfessorModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfessorModel professorModel = db.Professores.Find(id);
            if (professorModel == null)
            {
                return HttpNotFound();
            }
            return View(professorModel);
        }

        // POST: ProfessorModels/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Endereco,Telefone,Email,Disciplina")] ProfessorModel professorModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(professorModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(professorModel);
        }

        // GET: ProfessorModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfessorModel professorModel = db.Professores.Find(id);
            if (professorModel == null)
            {
                return HttpNotFound();
            }
            return View(professorModel);
        }

        // POST: ProfessorModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProfessorModel professorModel = db.Professores.Find(id);
            db.Professores.Remove(professorModel);
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
