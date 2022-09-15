using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PosApp.Models;
using System;
using System.Collections.Generic;

namespace PosApp.Controllers
{
    public class CardController : Controller
    {
        private protected CardDetails _cardDetails;
        public CardController()
        {
            CardDetails card = new CardDetails();
            _cardDetails = card;
        }
        // GET: CardController1
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

        // GET: CardController1/Details/5
        public ActionResult CardDetails()
        {
            CardDetails card = new CardDetails
            {
                CardType = "Debit Mastercard",
                Cardnumber = "539941******3369",
                IssuerLocation = "369/GLOBAL ACCELEREX",
                ExpiryDate = DateTime.Now,
                AuthorizationCode = "0000",
                CvnType = "OFFLINE CVM"

            };
            return View(card);
        }

        // GET: CardController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CardController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(CardIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: CardController1/Edit/5
        public ActionResult EditCard()
        {
            CardDetails card = new CardDetails
            {
                CardType = "Debit Mastercard",
                Cardnumber = "539941******3369",
                IssuerLocation = "369/GLOBAL ACCELEREX",
                ExpiryDate = DateTime.Now,
                AuthorizationCode = "0000",
                CvnType = "OFFLINE CVM"

            };
            return View(card);
        }

        // POST: CardController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(CardIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: CardController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CardController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(CardIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}
