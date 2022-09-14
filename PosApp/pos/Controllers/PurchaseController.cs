using PosApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pos.Controllers
{
    public class PurchaseController : Controller
    {
        private protected PurchaseDetails _purchaseDetails;
        public PurchaseController()
        {
            PurchaseDetails purchase = new PurchaseDetails();
            _purchaseDetails = purchase;
        }
        // GET: Purchase
        public ActionResult PurchaseIndex()
        {
            List<PurchaseDetails> purchase = new List<PurchaseDetails>();
            purchase.Add(new PurchaseDetails
            {
                Date = DateTime.Now,
                Stan = "003862",
                Amount = 0.01
            });
            return View(purchase);
        }

        // GET: Purchase/Details/5
        public ActionResult PurchaseDetails()
        {
            PurchaseDetails purchase = new PurchaseDetails
            {
                Date = DateTime.Now,
                Stan = "003862",
                Amount = 0.01
            };

            return View(purchase);
        }

        // GET: Purchase/Create
        public ActionResult CreatePurchase()
        {
            return View(_purchaseDetails);
        }

        // POST: Purchase/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("PurchaseIndex");
            }
            catch
            {
                return View();
            }
        }

        // GET: Purchase/Edit/5
        public ActionResult EditPurchase()
        {
            return View(_purchaseDetails);
        }

        // POST: Purchase/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("PurchaseIndex");
            }
            catch
            {
                return View();
            }
        }

        // GET: Purchase/Delete/5
        public ActionResult DeletePurchase()
        {
            return View(_purchaseDetails);
        }

        // POST: Purchase/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("PurchaseIndex");
            }
            catch
            {
                return View();
            }
        }
    }
}
