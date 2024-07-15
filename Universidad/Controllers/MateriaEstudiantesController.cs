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
    public class MateriaEstudiantesController : Controller
    {
        private UniversidadEntity db = new UniversidadEntity();

        // GET: MateriaEstudiantes
        public ActionResult Index()
        {
            var materiaEstudiante = db.MateriaEstudiante.Include(m => m.Estudiante).Include(m => m.Materia);
            return View(materiaEstudiante.ToList());
        }

        // GET: MateriaEstudiantes/Create
        public ActionResult Create()
        {
            ViewBag.EstudianteID = new SelectList(db.Estudiante, "ID", "Apellido");
            ViewBag.MateriaID = new SelectList(db.Materia, "MateriaID", "Titulo");
            return View();
        }

        // POST: MateriaEstudiantes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,MateriaID,EstudianteID")] MateriaEstudiante materiaEstudiante)
        {
            if (ModelState.IsValid)
            {
                var listaInscripcion = (from materia in db.MateriaEstudiante
                                       where materia.MateriaID == materiaEstudiante.MateriaID
                                       &&
                                       materia.EstudianteID == materiaEstudiante.EstudianteID
                                       select materia).ToList();

                if(listaInscripcion.Count() == 1)
                {
                    TempData["MensajeError"] = "Ocurrió un error al procesar la solicitud.";
                    return RedirectToAction("Create");
                }

                var listaMaterias = (from estudiante in db.MateriaEstudiante
                                        where estudiante.EstudianteID == materiaEstudiante.EstudianteID
                                        select estudiante).ToList();

                if (listaMaterias.Count() == 3)
                {
                    TempData["MensajeError"] = "Ocurrió un error al procesar la solicitud.";
                    return RedirectToAction("Create");
                }

                db.MateriaEstudiante.Add(materiaEstudiante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EstudianteID = new SelectList(db.Estudiante, "ID", "Apellido", materiaEstudiante.EstudianteID);
            ViewBag.MateriaID = new SelectList(db.Materia, "MateriaID", "Titulo", materiaEstudiante.MateriaID);
            return View(materiaEstudiante);
        }

        // GET: MateriaEstudiantes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MateriaEstudiante materiaEstudiante = db.MateriaEstudiante.Find(id);
            if (materiaEstudiante == null)
            {
                return HttpNotFound();
            }
            ViewBag.EstudianteID = new SelectList(db.Estudiante, "ID", "Apellido", materiaEstudiante.EstudianteID);
            ViewBag.MateriaID = new SelectList(db.Materia, "MateriaID", "Titulo", materiaEstudiante.MateriaID);
            return View(materiaEstudiante);
        }

        // POST: MateriaEstudiantes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,MateriaID,EstudianteID")] MateriaEstudiante materiaEstudiante)
        {
            if (ModelState.IsValid)
            {
                var listaInscripcion = (from materia in db.MateriaEstudiante
                                        where materia.MateriaID == materiaEstudiante.MateriaID
                                        &&
                                        materia.EstudianteID == materiaEstudiante.EstudianteID
                                        select materia).ToList();

                if (listaInscripcion.Count() == 1)
                {
                    TempData["MensajeError"] = "Ocurrió un error al procesar la solicitud.";
                    return RedirectToAction("Edit");
                }

                var listaMaterias = (from estudiante in db.MateriaEstudiante
                                     where estudiante.EstudianteID == materiaEstudiante.EstudianteID
                                     select estudiante).ToList();

                if (listaMaterias.Count() == 3)
                {
                    TempData["MensajeError"] = "Ocurrió un error al procesar la solicitud.";
                    return RedirectToAction("Edit");
                }

                db.Entry(materiaEstudiante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EstudianteID = new SelectList(db.Estudiante, "ID", "Apellido", materiaEstudiante.EstudianteID);
            ViewBag.MateriaID = new SelectList(db.Materia, "MateriaID", "Titulo", materiaEstudiante.MateriaID);
            return View(materiaEstudiante);
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
