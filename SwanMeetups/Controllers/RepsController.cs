using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SwanMeetups.DAL;
using SwanMeetups.Models;

namespace SwanMeetups.Controllers
{
    public class RepsController : Controller
    {
        private EventDBContext db = new EventDBContext();

        // GET: Reps
        public ActionResult Index()
        {

            IEnumerable<SelectListItem> regionItems = db.Regions.AsEnumerable().Select(c => new SelectListItem()
            {
                Text = c.Region,
                Value = c.RegionID.ToString(),
                Selected = false,
            });
            SelectList RegionList = new SelectList(regionItems, "Value", "Text");
            ViewBag.RegionList = RegionList;

            return View(db.Reps.ToList());
        }

        // GET: Reps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reps reps = db.Reps.Find(id);
            if (reps == null)
            {
                return HttpNotFound();
            }
            return View(reps);
        }

        // GET: Reps/Create
        public ActionResult Create()
        {
            IEnumerable<SelectListItem> regionItems =  db.Regions.AsEnumerable().Select(c => new SelectListItem()
            {
                Text = c.Region,
                Value = c.RegionID.ToString(),
                Selected = false,
            });
            SelectList RegionList = new SelectList(regionItems, "Value", "Text");
            ViewBag.RegionList = RegionList;

            return View();
        }

        // POST: Reps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RepID,FirstName,LastName,RegionID,Twitter,Facebook,Instagram,Email,Active")] Reps reps)
        {
            if (ModelState.IsValid)
            {
                db.Reps.Add(reps);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reps);
        }

        // GET: Reps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reps reps = db.Reps.Find(id);
            if (reps == null)
            {
                return HttpNotFound();
            }

            IEnumerable<SelectListItem> regionItems = db.Regions.AsEnumerable().Select(c => new SelectListItem()
            {
                Text = c.Region,
                Value = c.RegionID.ToString(),
                Selected = false,
            });
            SelectList RegionList = new SelectList(regionItems, "Value", "Text");
            ViewBag.RegionList = RegionList;

            return View(reps);
        }

        // POST: Reps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RepID,FirstName,LastName,RegionID,Twitter,Facebook,Instagram,Email,Active")] Reps reps)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reps).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reps);
        }

        // GET: Reps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reps reps = db.Reps.Find(id);
            if (reps == null)
            {
                return HttpNotFound();
            }
            return View(reps);
        }

        // POST: Reps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reps reps = db.Reps.Find(id);
            db.Reps.Remove(reps);
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
