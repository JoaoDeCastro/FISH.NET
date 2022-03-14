using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FishDemo.Models;

namespace FishDemo.Controllers
{
    public class RideModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RideModels
        public ActionResult Index()
        {
            return View(db.Rides.ToList());
        }

        // GET: RideModels/Details/5
        
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RideModel rideModel = db.Rides.Find(id);
            if (rideModel == null)
            {
                return HttpNotFound();
            }
            return View(rideModel);
        }

        // GET: RideModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RideModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RideId,pickUpDate,Status,Time,DestinationStreet,DestinationCity,DestinationState,DestinationZip,SpecialNeed,LenghtOfAppointment")] RideModel rideModel)
        {
            if (ModelState.IsValid)
            {
                db.Rides.Add(rideModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rideModel);
        }

        // GET: RideModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RideModel rideModel = db.Rides.Find(id);
            if (rideModel == null)
            {
                return HttpNotFound();
            }
            return View(rideModel);
        }

        // POST: RideModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RideId,pickUpDate,Status,Time,DestinationStreet,DestinationCity,DestinationState,DestinationZip,SpecialNeed,LenghtOfAppointment")] RideModel rideModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rideModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rideModel);
        }

        // GET: RideModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RideModel rideModel = db.Rides.Find(id);
            if (rideModel == null)
            {
                return HttpNotFound();
            }
            return View(rideModel);
        }

        // POST: RideModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RideModel rideModel = db.Rides.Find(id);
            db.Rides.Remove(rideModel);
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
