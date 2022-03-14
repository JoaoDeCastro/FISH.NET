using FishDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FishDemo.Controllers
{
    [Authorize(Roles = "Manager, Adm, Jhc")]
    public class ManagerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Manager




        public ActionResult Panel()
        {
            
                return View();
            
        }
        public ActionResult newCalendar()
        {

            return View();

        }

        public ActionResult Calendar()
        {
            
            return View(db.Customers.ToList());
            
        }
       

        public JsonResult GetEvents()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {

                List <RideModel> events = db.Rides.ToList();

                return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
                
                
            }
        }

        /*driver*/
        public ActionResult DriverCalendar()
        {

            return View();

        }


        public JsonResult GetDrivers()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {

                List<DriverModel> events = db.Drivers.ToList();

                return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };


            }
        }
        public ActionResult DriverList()
        {

            return View(db.Drivers.ToList());
        }

        public ActionResult CreateDriver()
        {

            return View();


        }

        public ActionResult DriverCreated()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public ActionResult CreateDriver(DriverModel driverModel)
        {
            if (ModelState.IsValid)
            {
                db.Drivers.Add(driverModel);

                db.SaveChanges();
                return RedirectToAction("DriverCreated");
            }

            return View(driverModel);
        }

        
        public ActionResult Delete(int? id)

        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DriverModel driverModel = db.Drivers.Find(id);
            if (driverModel == null)
            {
                return HttpNotFound();
            }
            return View(driverModel);
        }

        // POST: CustomerModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DriverModel driverModel = db.Drivers.Find(id);
            db.Drivers.Remove(driverModel);
            db.SaveChanges();
            return RedirectToAction("Panel");
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