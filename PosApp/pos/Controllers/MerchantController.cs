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
        private protected MerchantDetails _merchantDetails;
        public MerchantController()
        {
            MerchantDetails merchant = new MerchantDetails();
            
            _merchantDetails = merchant;
        }
        // GET: Merchant
        public ActionResult MerchantIndex()
        {
            List<MerchantDetails> merchant = new List<MerchantDetails>();
            merchant.Add(new MerchantDetails
            {
                Name = "LIZPEE BLOBAL RESOURCES",
                Address = "NO. 174 NTA/MBUARA RD, PORTHARCOURT",
                TerminalId = "23011845"

            });
            return View(merchant);
        }

        // GET: Merchant/Details/5
        public ActionResult MerchantDetails()
        {
            MerchantDetails merchant = new MerchantDetails
            {
                Name ="LIZPEE BLOBAL RESOURCES",
                Address = "NO. 174 NTA/MBUARA RD, PORTHARCOURT",
                TerminalId = "23011845"

            };
            return View(merchant);
        }

        // GET: Merchant/Create
        public ActionResult CreateMerchant()
        {
            return View(_merchantDetails);
        }

        // POST: Merchant/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("MerchantIndex");
            }
            catch
            {
                return View();
            }
        }

        // GET: Merchant/Edit/5
        public ActionResult EditMerchant()
        {
            return View(_merchantDetails);
        }

        // POST: Merchant/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("MerchantIndex");
            }
            catch
            {
                return View();
            }
        }

        // GET: Merchant/Delete/5
        public ActionResult DeleteMerchant()
        {
            return View(_merchantDetails);
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
