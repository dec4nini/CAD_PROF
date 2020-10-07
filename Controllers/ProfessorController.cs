using CAD_Prof.Context;
using CAD_Prof.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CAD_Prof.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly Contexto db = new Contexto();

        // GET: Index
        public ActionResult Index()
        {

            return View(db.Professores.ToList());
        }

        #region Create

        //GET: Create
        public ActionResult Create()
        {

            return View();
        }

        //POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProfessorModel professorModel)
        {
            if (ModelState.IsValid)
            {
                db.Professores.Add(professorModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(professorModel);
        }
        #endregion

        #region Details
        // GET: Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            ProfessorModel professorModel = db.Professores.Find(id);
            if (professorModel == null)
            {
                return HttpNotFound();
            }
            return View(professorModel);
        }
        #endregion

        #region Edit
        //GET: Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            ProfessorModel professorModel = db.Professores.Find(id);
            if (professorModel == null)
            {
                return HttpNotFound();
            }
            return View(professorModel);
        }

        //POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProfessorModel professorModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(professorModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(professorModel);
        }
        #endregion

        #region Delete
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

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProfessorModel professorModel = db.Professores.Find(id);
            db.Professores.Remove(professorModel);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}