using Microsoft.AspNetCore.Mvc;
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
        private protected TransactionDetails _transactionDetails;

        public TransactionController()
        {
            TransactionDetails transaction = new TransactionDetails();

            _transactionDetails = transaction;
            
        }
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
               Id = 1,
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
        public ActionResult CreateTransaction()
        {
            return View(_transactionDetails);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionDetails transaction)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("TransactionIndex");
            }
            catch
            {
                return View();
            }
        }

        // GET: Transaction/Edit/5
        public ActionResult EditTransaction(string id)
        {

            return View(_transactionDetails);
        }

        // POST: Transaction/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("TransactionIndex");
            }
            catch
            {
                return View();
            }
        }

        // GET: Transaction/Delete/5
        public ActionResult DeleteTransaction()
        {
            return View(_transactionDetails);
        }

        // POST: Transaction/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("TransactionIndex");
            }
            catch
            {
                return View();
            }
        }
    }
}
