using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PosApp.Models;
using System;
using System.Collections.Generic;

namespace PosApp.Controllers
{
    public class PurchaseController1 : Controller
    {
        private protected PurchaseDetails _purchaseDetails;
        public PurchaseController1()
        {
            PurchaseDetails purchase = new PurchaseDetails();
            _purchaseDetails = purchase;
        }
        // GET: PurchaseController1
        public ActionResult Index()
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

            // GET: PurchaseController1/Details/5
        public ActionResult Details(int id)
        {
            PurchaseDetails purchase = new PurchaseDetails
            {
                Date = DateTime.Now,
                Stan = "003862",
                Amount = 0.01
            };

            return View(purchase);
        }

        // GET: PurchaseController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PurchaseController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PurchaseController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PurchaseController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PurchaseController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PurchaseController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
