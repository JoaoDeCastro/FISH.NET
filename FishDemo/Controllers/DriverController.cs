using FishDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FishDemo.Controllers
{
    [Authorize(Roles = "Driver")]
    public class DriverController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Driver

        public ActionResult Panel()
        {
            return View();
        }

        public ActionResult Calendar()
        {
            return View();
        }
        public ActionResult FormCreated()
        {
            return View();
        }

        public ActionResult DatesAvailable()
        {
            

            return View();


        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult DatesAvailable(DriverModel driverModel)
        {

            if (ModelState.IsValid)
            {
                db.Entry(driverModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(driverModel);
        }


        public JsonResult GetDrivers()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {

                List<DriverModel> events = db.Drivers.ToList();
                return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

            }
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



    }

}