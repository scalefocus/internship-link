using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InternshipLink.Web.Data;

namespace InternshipLink.Web.Controllers
{
    public class InternshipsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Internships
        public ActionResult Index()
        {
            var internships = db.Internships.Include(i => i.Company).Include(i => i.Student);
            return View(internships.ToList());
        }

        // GET: Internships/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Internship internship = db.Internships.Find(id);
            if (internship == null)
            {
                return HttpNotFound();
            }
            return View(internship);
        }

        // GET: Internships/Create
        public ActionResult Create()
        {
            ViewBag.CompanyID = new SelectList(db.Companies, "ID", "Name");
            ViewBag.StudentID = new SelectList(db.Students, "ID", "FirstName");
            return View();
        }

        // POST: Internships/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,StartDate,EndDate,StudentID,CompanyID")] Internship internship)
        {
            if (ModelState.IsValid)
            {
                db.Internships.Add(internship);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CompanyID = new SelectList(db.Companies, "ID", "Name", internship.CompanyID);
            ViewBag.StudentID = new SelectList(db.Students, "ID", "FirstName", internship.StudentID);
            return View(internship);
        }

        // GET: Internships/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Internship internship = db.Internships.Find(id);
            if (internship == null)
            {
                return HttpNotFound();
            }
            ViewBag.CompanyID = new SelectList(db.Companies, "ID", "Name", internship.CompanyID);
            ViewBag.StudentID = new SelectList(db.Students, "ID", "FirstName", internship.StudentID);
            return View(internship);
        }

        // POST: Internships/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,StartDate,EndDate,StudentID,CompanyID")] Internship internship)
        {
            if (ModelState.IsValid)
            {
                db.Entry(internship).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CompanyID = new SelectList(db.Companies, "ID", "Name", internship.CompanyID);
            ViewBag.StudentID = new SelectList(db.Students, "ID", "FirstName", internship.StudentID);
            return View(internship);
        }

        // GET: Internships/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Internship internship = db.Internships.Find(id);
            if (internship == null)
            {
                return HttpNotFound();
            }
            return View(internship);
        }

        // POST: Internships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Internship internship = db.Internships.Find(id);
            db.Internships.Remove(internship);
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
