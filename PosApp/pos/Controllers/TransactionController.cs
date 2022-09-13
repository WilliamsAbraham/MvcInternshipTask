using PosApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pos.Controllers
{
    public class TransactionController : Controller
    {
        // GET: Transaction
        public ActionResult TransactionIndex()
        {
            List<TransactionDetails> transaction = new List<TransactionDetails>();
            transaction.Add(new TransactionDetails
            {
                ResponseCode = 91,
                Aid = "A000000000041010",
                Rrn = "000210002450 Accelerex 2.2. 0-090921-LINT",
                Ptad = "Global Accelerex"
            }); 
            return View(transaction);
        }

        // GET: Transaction/Details/5
        public ActionResult TransactionDetails()
        {
            TransactionDetails transaction = new TransactionDetails
            {
                ResponseCode = 91,
                Aid = "A000000000041010",
                Rrn = "000210002450 Accelerex 2.2. 0-090921-LINT",
                Ptad =  "Global Accelerex"
            };
            if(transaction.ResponseCode == 91)
            {
                return View("TransactionDeclinedDetails", transaction);

            }
            else
                return View(transaction);
        }

        // GET: Transaction/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Transaction/Create
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

        // GET: Transaction/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Transaction/Edit/5
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

        // GET: Transaction/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Transaction/Delete/5
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
