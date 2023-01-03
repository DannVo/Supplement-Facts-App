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
    public class TestingProductsController : Controller
    {
        private WebDBConn db = new WebDBConn();

        // GET: TestingProducts
        public ActionResult Index()
        {
            return View(db.TestingProducts.ToList());
        }

        // GET: TestingProducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestingProduct testingProduct = db.TestingProducts.Find(id);
            if (testingProduct == null)
            {
                return HttpNotFound();
            }
            return View(testingProduct);
        }

        // GET: TestingProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestingProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "proID,proName,proImg,proDesc,quantity,priceDeli,priceReceived,dateReceive,dateDeli")] TestingProduct testingProduct)
        {
            if (ModelState.IsValid)
            {
                db.TestingProducts.Add(testingProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(testingProduct);
        }

        // GET: TestingProducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestingProduct testingProduct = db.TestingProducts.Find(id);
            if (testingProduct == null)
            {
                return HttpNotFound();
            }
            return View(testingProduct);
        }

        // POST: TestingProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "proID,proName,proImg,proDesc,quantity,priceDeli,priceReceived,dateReceive,dateDeli")] TestingProduct testingProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testingProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(testingProduct);
        }

        // GET: TestingProducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestingProduct testingProduct = db.TestingProducts.Find(id);
            if (testingProduct == null)
            {
                return HttpNotFound();
            }
            return View(testingProduct);
        }

        // POST: TestingProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TestingProduct testingProduct = db.TestingProducts.Find(id);
            db.TestingProducts.Remove(testingProduct);
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
