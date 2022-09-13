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
        public ActionResult Create()
        {
            return View();
        }

        // POST: Purchase/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Purchase/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Purchase/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Purchase/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Purchase/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
