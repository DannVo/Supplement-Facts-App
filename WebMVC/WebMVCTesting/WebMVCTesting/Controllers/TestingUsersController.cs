using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebMVCTesting.Models;

namespace WebMVCTesting.Controllers
{
    public class TestingUsersController : Controller
    {
        private WebDBConn db = new WebDBConn();

        // GET: TestingUsers
        public ActionResult Index()
        {
            return View(db.TestingUsers.ToList());
        }

        // GET: TestingUsers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestingUser testingUser = db.TestingUsers.Find(id);
            if (testingUser == null)
            {
                return HttpNotFound();
            }
            return View(testingUser);
        }

        // GET: TestingUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestingUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,email,password,fullname,address,phone,createdAt,status")] TestingUser testingUser)
        {
            if (ModelState.IsValid)
            {
                db.TestingUsers.Add(testingUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(testingUser);
        }

        // GET: TestingUsers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestingUser testingUser = db.TestingUsers.Find(id);
            if (testingUser == null)
            {
                return HttpNotFound();
            }
            return View(testingUser);
        }

        // POST: TestingUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,email,password,fullname,address,phone,createdAt,status")] TestingUser testingUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testingUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(testingUser);
        }

        // GET: TestingUsers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestingUser testingUser = db.TestingUsers.Find(id);
            if (testingUser == null)
            {
                return HttpNotFound();
            }
            return View(testingUser);
        }

        // POST: TestingUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TestingUser testingUser = db.TestingUsers.Find(id);
            db.TestingUsers.Remove(testingUser);
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
