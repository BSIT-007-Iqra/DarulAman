using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DarulAman.Models;

namespace DarulAman.Controllers
{
    public class tbl_DonationController : Controller
    {
        private Model1 db = new Model1();

        // GET: tbl_Donation
        public ActionResult Index()
        {
            return View(db.tbl_Donation.ToList());
        }

        // GET: tbl_Donation/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Donation tbl_Donation = db.tbl_Donation.Find(id);
            if (tbl_Donation == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Donation);
        }

        // GET: tbl_Donation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_Donation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DONATION_ID,FIRST_NAME,LAST_NAME,EMAIL,AMOUNT,STATUS,DATE")] tbl_Donation tbl_Donation)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Donation.Add(tbl_Donation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Donation);
        }

        // GET: tbl_Donation/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Donation tbl_Donation = db.tbl_Donation.Find(id);
            if (tbl_Donation == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Donation);
        }

        // POST: tbl_Donation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DONATION_ID,FIRST_NAME,LAST_NAME,EMAIL,AMOUNT,STATUS,DATE")] tbl_Donation tbl_Donation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Donation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Donation);
        }

        // GET: tbl_Donation/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Donation tbl_Donation = db.tbl_Donation.Find(id);
            if (tbl_Donation == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Donation);
        }

        // POST: tbl_Donation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Donation tbl_Donation = db.tbl_Donation.Find(id);
            db.tbl_Donation.Remove(tbl_Donation);
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
