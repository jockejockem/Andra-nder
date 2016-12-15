using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GräsÄnklingar.Models;

namespace GräsÄnklingar.Controllers
{
    public class AnderController : Controller
    {
        private GräsÄnklingarDB db = new GräsÄnklingarDB();

        // GET: Ander
        public ActionResult Index()
        {
            return View(db.Ands.ToList());
        }

        // GET: Ander/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            And and = db.Ands.Find(id);
            if (and == null)
            {
                return HttpNotFound();
            }
            return View(and);
        }

        // GET: Ander/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ander/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "andid,andNamn,intressen")] And and)
        {
            if (ModelState.IsValid)
            {
                db.Ands.Add(and);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(and);
        }

        // GET: Ander/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            And and = db.Ands.Find(id);
            if (and == null)
            {
                return HttpNotFound();
            }
            return View(and);
        }

        // POST: Ander/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "andid,andNamn,intressen")] And and)
        {
            if (ModelState.IsValid)
            {
                db.Entry(and).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(and);
        }

        // GET: Ander/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            And and = db.Ands.Find(id);
            if (and == null)
            {
                return HttpNotFound();
            }
            return View(and);
        }

        // POST: Ander/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            And and = db.Ands.Find(id);
            db.Ands.Remove(and);
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
