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
    public class TeacherController : Controller
    {
        private CourseManagerEntities db = new CourseManagerEntities();

        //
        // GET: /Teacher/

        public ActionResult Index()
        {
            return View(db.Teacheres.ToList());
        }

        //
        // GET: /Teacher/Details/5

        public ActionResult Details(int id = 0)
        {
            Teacheres teachers = db.Teacheres.Find(id);
            if (teachers == null)
            {
                return HttpNotFound();
            }
            return View(teachers);
        }

        //
        // GET: /Teacher/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Teacher/Create

        [HttpPost]
        public ActionResult Create(Teacheres teachers)
        {
            if (ModelState.IsValid)
            {
                db.Teacheres.Add(teachers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(teachers);
        }

        //
        // GET: /Teacher/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Teacheres teachers = db.Teacheres.Find(id);
            if (teachers == null)
            {
                return HttpNotFound();
            }
            return View(teachers);
        }

        //
        // POST: /Teacher/Edit/5

        [HttpPost]
        public ActionResult Edit(Teacheres teachers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teachers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(teachers);
        }

        //
        // GET: /Teacher/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Teacheres teachers = db.Teacheres.Find(id);
            if (teachers == null)
            {
                return HttpNotFound();
            }
            return View(teachers);
        }

        //
        // POST: /Teacher/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Teacheres teachers = db.Teacheres.Find(id);
            db.Teacheres.Remove(teachers);
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