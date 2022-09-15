using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PosApp.Models;
using System.Collections.Generic;

namespace PosApp.Controllers
{
    public class MerchantController1 : Controller
    {
        private protected MerchantDetails _merchantDetails;
        public MerchantController1()
        {
            MerchantDetails merchant = new MerchantDetails();

            _merchantDetails = merchant;
        }
        // GET: MerchantController1
        public ActionResult Index()
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

        // GET: MerchantController1/Details/5
        public ActionResult Details(int id)
        {
            MerchantDetails merchant = new MerchantDetails
            {
                Name = "LIZPEE BLOBAL RESOURCES",
                Address = "NO. 174 NTA/MBUARA RD, PORTHARCOURT",
                TerminalId = "23011845"

            };
            return View(merchant);
        }

        // GET: MerchantController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MerchantController1/Create
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

        // GET: MerchantController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MerchantController1/Edit/5
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

        // GET: MerchantController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MerchantController1/Delete/5
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
