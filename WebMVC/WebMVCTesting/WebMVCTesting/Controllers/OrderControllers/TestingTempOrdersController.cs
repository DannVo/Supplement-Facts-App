using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebMVCTesting.Models.AllOrder;

namespace WebMVCTesting.Controllers.OrderControllers
{
    public class TestingTempOrdersController : Controller
    {
        private WebDBEntities db = new WebDBEntities();

        // GET: TestingTempOrders
        public ActionResult Index()
        {
            return View(db.TestingTempOrders.ToList());
        }

        // GET: TestingTempOrders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestingTempOrder testingTempOrder = db.TestingTempOrders.Find(id);
            if (testingTempOrder == null)
            {
                return HttpNotFound();
            }
            return View(testingTempOrder);
        }

        // GET: TestingTempOrders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestingTempOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "tempID,cusID,proID,quantity")] TestingTempOrder testingTempOrder)
        {
            if (ModelState.IsValid)
            {
                db.TestingTempOrders.Add(testingTempOrder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(testingTempOrder);
        }

        // GET: TestingTempOrders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestingTempOrder testingTempOrder = db.TestingTempOrders.Find(id);
            if (testingTempOrder == null)
            {
                return HttpNotFound();
            }
            return View(testingTempOrder);
        }

        // POST: TestingTempOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "tempID,cusID,proID,quantity")] TestingTempOrder testingTempOrder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testingTempOrder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(testingTempOrder);
        }

        // GET: TestingTempOrders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestingTempOrder testingTempOrder = db.TestingTempOrders.Find(id);
            if (testingTempOrder == null)
            {
                return HttpNotFound();
            }
            return View(testingTempOrder);
        }

        // POST: TestingTempOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TestingTempOrder testingTempOrder = db.TestingTempOrders.Find(id);
            db.TestingTempOrders.Remove(testingTempOrder);
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
