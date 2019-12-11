using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coursemanger.Models;

namespace Coursemanger.Controllers
{
    public class StudentController : Controller
    {
        private CourseManagerEntities db = new CourseManagerEntities();

        //
        // GET: /Student/

        public ActionResult Index()
        {
            return View(db.Teacheres.ToList());
        }

        //
        // GET: /Student/Details/5

        public ActionResult Details(int id = 0)
        {
            Teacheres teacheres = db.Teacheres.Find(id);
            if (teacheres == null)
            {
                return HttpNotFound();
            }
            return View(teacheres);
        }

        //
        // GET: /Student/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Student/Create

        [HttpPost]
        public ActionResult Create(Teacheres teacheres)
        {
            if (ModelState.IsValid)
            {
                db.Teacheres.Add(teacheres);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(teacheres);
        }

        //
        // GET: /Student/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Teacheres teacheres = db.Teacheres.Find(id);
            if (teacheres == null)
            {
                return HttpNotFound();
            }
            return View(teacheres);
        }

        //
        // POST: /Student/Edit/5

        [HttpPost]
        public ActionResult Edit(Teacheres teacheres)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teacheres).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(teacheres);
        }

        //
        // GET: /Student/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Teacheres teacheres = db.Teacheres.Find(id);
            if (teacheres == null)
            {
                return HttpNotFound();
            }
            return View(teacheres);
        }

        //
        // POST: /Student/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Teacheres teacheres = db.Teacheres.Find(id);
            db.Teacheres.Remove(teacheres);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}