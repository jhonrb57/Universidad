using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Universidad.Data;
using Universidad.Models;

namespace Universidad.Controllers
{
    public class MateriaProfesorsController : Controller
    {
        private UniversidadEntity db = new UniversidadEntity();

        // GET: MateriaProfesors
        public ActionResult Index()
        {
            var materiaProfesor = db.MateriaProfesor.Include(m => m.Materia).Include(m => m.Profesor);
            return View(materiaProfesor.ToList());
        }

        // GET: MateriaProfesors/Create
        public ActionResult Create()
        {
            ViewBag.MateriaID = new SelectList(db.Materia, "MateriaID", "Titulo");
            ViewBag.ProfesorID = new SelectList(db.Profesor, "ID", "Apellido");
            return View();
        }

        // POST: MateriaProfesors/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,MateriaID,ProfesorID")] MateriaProfesor materiaProfesor)
        {
            if (ModelState.IsValid)
            {
                var listProfesor = (from p in db.MateriaProfesor
                                   where p.ProfesorID == materiaProfesor.ProfesorID
                                   select p.ProfesorID).ToList();

                if(listProfesor.Count() > 1)
                {
                    TempData["MensajeError"] = "Ocurrió un error al procesar la solicitud.";
                    return RedirectToAction("Create");
                }

                db.MateriaProfesor.Add(materiaProfesor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MateriaID = new SelectList(db.Materia, "MateriaID", "Titulo", materiaProfesor.MateriaID);
            ViewBag.ProfesorID = new SelectList(db.Profesor, "ID", "Apellido", materiaProfesor.ProfesorID);
            return View(materiaProfesor);
        }

        // GET: MateriaProfesors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MateriaProfesor materiaProfesor = db.MateriaProfesor.Find(id);
            if (materiaProfesor == null)
            {
                return HttpNotFound();
            }
            ViewBag.MateriaID = new SelectList(db.Materia, "MateriaID", "Titulo", materiaProfesor.MateriaID);
            ViewBag.ProfesorID = new SelectList(db.Profesor, "ID", "Apellido", materiaProfesor.ProfesorID);
            return View(materiaProfesor);
        }

        // POST: MateriaProfesors/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,MateriaID,ProfesorID")] MateriaProfesor materiaProfesor)
        {
            if (ModelState.IsValid)
            {
                var listProfesor = (from p in db.MateriaProfesor
                                    where p.ProfesorID == materiaProfesor.ProfesorID
                                    select p.ProfesorID).ToList();

                if (listProfesor.Count() > 1)
                {
                    return RedirectToAction("Index");
                }

                db.Entry(materiaProfesor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MateriaID = new SelectList(db.Materia, "MateriaID", "Titulo", materiaProfesor.MateriaID);
            ViewBag.ProfesorID = new SelectList(db.Profesor, "ID", "Apellido", materiaProfesor.ProfesorID);
            return View(materiaProfesor);
        }

        // GET: MateriaProfesors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MateriaProfesor materiaProfesor = db.MateriaProfesor.Find(id);
            if (materiaProfesor == null)
            {
                return HttpNotFound();
            }
            return View(materiaProfesor);
        }

        // POST: MateriaProfesors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MateriaProfesor materiaProfesor = db.MateriaProfesor.Find(id);
            db.MateriaProfesor.Remove(materiaProfesor);
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
