using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using WebMVCTesting.Models;
using WebMVCTesting.Models.AllOrder;

namespace WebMVCTesting.Controllers
{
    public class HomeController : Controller
    {
        private WebDBConn db = new WebDBConn();
        private WebDBEntities db2 = new WebDBEntities();
        public ActionResult Index()
        {
            if (Session["ID"] != null)
            {
                return View();

            }
            else
            {
                return View("Login");
            }
        }

        public ActionResult About()
        {
            if (Session["ID"] != null)
            {
                ViewBag.Message = "Your application description page.";
                return View();

            }
            else
            {
                return View("Login");
            }


        }

        public ActionResult Contact()
        {
            if (Session["ID"] != null)
            {
                ViewBag.Message = "Your contact page.";
                return View();

            }
            else
            {
                return View("Login");
            }


        }

        public ActionResult Product()
        {
            if (Session["ID"] != null)
            {
                ViewBag.Message = "List of Product";

                return View(db.TestingProducts.ToList());


            }
            else
            {
                return View("Login");
            }
        }
        public ActionResult BuySuccess()
        {
            if (Session["ID"] != null)
            {
                ViewBag.Message = "List of Product";

                return View();


            }
            else
            {
                return View("Login");
            }
        }

        public ActionResult ConfirmPage()
        {
            if (Session["ID"] != null)
            {
                ViewBag.Message = "List of Product";

                return View();


            }
            else
            {
                return View("Login");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Confirm([Bind(Include = "tempID,cusID,proID,quantity")] TestingTempOrder testingTempOrder)
        {
            if (ModelState.IsValid)
            {
                db2.TestingTempOrders.Add(testingTempOrder);
                db2.SaveChanges();
                return RedirectToAction("BuySuccess");
            }

            return View(testingTempOrder);
        }

        public ActionResult DetailProduct(int? id)
        {
            if (Session["ID"] != null)
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
                var detail_pro = new TestingProduct
                {
                    proID = testingProduct.proID,
                    proName = testingProduct.proName,
                    proImg = testingProduct.proImg,
                    priceDeli = testingProduct.priceDeli,
                    proDesc = testingProduct.proDesc,
                };
                ViewData["ProDetail"] = detail_pro;
                return View();
            }
            else
            {
                return View("Login");
            }
        }

        public ActionResult DetailOrder()
        {
            if (Session["ID"] != null)
            {
                
                int i = (int)Session["ID"];
                var data2 = db2.TestingTempOrders.Where(m => m.cusID == i).ToList();
                
                TestingProduct testingProduct = db.TestingProducts.Find(data2.FirstOrDefault().proID);

                if (data2.Count > 0)
                {
                    var detail_pro = new TestingProduct
                    {
                        proID = testingProduct.proID,
                        proName = testingProduct.proName,
                        proImg = testingProduct.proImg,
                        priceDeli = testingProduct.priceDeli,
                        proDesc = testingProduct.proDesc,
                    };
                    ViewData["ProDetail"] = detail_pro;
                    ViewData["Quantity"] = data2.FirstOrDefault().quantity;
                    return View();
                }
                return View();
            }
            else
            {
                return View("Login");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add2Order([Bind(Include = "tempID,cusID,proID,quantity")] TestingTempOrder testingTempOrder)
        {
            if (ModelState.IsValid)
            {
                db2.TestingTempOrders.Add(testingTempOrder);
                db2.SaveChanges();
                
                Session["ProID"] = testingTempOrder.proID;
                return RedirectToAction("Product");
            }

            return View(testingTempOrder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add2Buy([Bind(Include = "orderName,cusName,address,payMethod,totalPay")] TestingOrder testingOrder)
        {
            if (ModelState.IsValid)
            {
                db2.TestingOrders.Add(testingOrder);
                db2.SaveChanges();
                var data = db2.TestingOrders.Where(m => m.cusName == testingOrder.cusName && m.orderName == testingOrder.orderName).ToList();
                Session["OrderID"] = data.FirstOrDefault().orderID;
                
                return RedirectToAction("ConfirmPage");
            }

            return View(testingOrder);
        }

        //Login
        public ActionResult Login()
        {
            if (Session["ID"] != null)
            {
                ViewBag.Message = "Login Page";
                return View("Index");

            }
            else
            {
                return View();
            }


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Verify(string email, string password)
        {
            if (ModelState.IsValid)
            {
                var dataUser = db.TestingUsers.Where(d => d.email.Equals(email) && d.password.Equals(password)).ToList();

                if (dataUser.Count > 0)
                {
                    Session["ID"] = dataUser.FirstOrDefault().id;
                    Session["Fullname"] = dataUser.FirstOrDefault().fullname;
                    Session["Email"] = dataUser.FirstOrDefault().email;
                    Session["Address"] = dataUser.FirstOrDefault().address;
                    return RedirectToAction("Index");

                }
                else
                {
                    ViewBag.error = "Login failed!";
                    return RedirectToAction("Login");
                }


            }
            return View();

        }

        //Logout
        public ActionResult Logout()
        {
            Session.Clear();//remove session
            return RedirectToAction("Login");
        }
    }
}