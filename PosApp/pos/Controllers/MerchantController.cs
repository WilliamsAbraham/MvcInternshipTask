using PosApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pos.Controllers
{
    public class MerchantController : Controller
    {
        // GET: Merchant
        public ActionResult Index()
        {
            return View();
        }

        // GET: Merchant/Details/5
        public ActionResult MerchantDetails()
        {
            MerchantDetails merchant = new MerchantDetails
            {
                Name ="hhhhh",
                Address = "kdkfdkf",
                Authors = new List<string> { "kkakxak","xbakxbakb"},
                MerchantId = 1,
                TerminalId = "knsncs"

            };
            return View(merchant);
        }

        // GET: Merchant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Merchant/Create
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

        // GET: Merchant/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Merchant/Edit/5
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

        // GET: Merchant/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Merchant/Delete/5
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
