using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PosApp.Models;
using System.Collections.Generic;

namespace PosApp.Controllers
{
    public class TransactionController1 : Controller
    {
        private protected TransactionDetails _transactionDetails;
        public TransactionController1()
        {
            TransactionDetails transaction = new TransactionDetails();

            _transactionDetails = transaction;
        }
        // GET: TransactionController1
        public ActionResult Index()
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

        // GET: TransactionController1/Details/5
        public ActionResult Details()
        {
            TransactionDetails transaction = new TransactionDetails
            {
                Id = 1,
                ResponseCode = 91,
                Aid = "A000000000041010",
                Rrn = "000210002450 Accelerex 2.2. 0-090921-LINT",
                Ptad = "Global Accelerex"
            };
            if (transaction.ResponseCode == 91)
            {
                return View("TransactionDeclinedDetails", transaction);

            }
            else
                return View(transaction);
        }

        // GET: TransactionController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TransactionController1/Create
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

        // GET: TransactionController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TransactionController1/Edit/5
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

        // GET: TransactionController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TransactionController1/Delete/5
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
