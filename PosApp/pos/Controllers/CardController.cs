using PosApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pos.Controllers
{
    public class CardController : Controller
    {
        // GET: Card
        public ActionResult CardIndex()
        {
            List<CardDetails> card = new List<CardDetails>();
            card.Add(new CardDetails
            {
                CardType = "Debit Mastercard",
                Cardnumber = "539941******3369",
                IssuerLocation = "369/GLOBAL ACCELEREX",
                ExpiryDate = DateTime.Now,
                AuthorizationCode = "0000",
                CvnType = "OFFLINE CVM"

            });
            return View(card);
            
        }

        // GET: Card/Details/5
        public ActionResult CardDetails()
        {
            CardDetails card = new CardDetails
            {
                CardType = "Debit Mastercard",
                Cardnumber = "539941******3369",
                IssuerLocation = "369/GLOBAL ACCELEREX",
                ExpiryDate = DateTime.Now,
                AuthorizationCode ="0000",
                CvnType = "OFFLINE CVM"
                
            };
            return View(card);
        }

        // GET: Card/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Card/Create
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

        // GET: Card/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Card/Edit/5
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

        // GET: Card/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Card/Delete/5
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
