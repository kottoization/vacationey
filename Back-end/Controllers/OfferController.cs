﻿using Backend.Models;
using Backend.Models.DbModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Backend.Controllers
{
    public class OfferController : Controller
    {
        private readonly DatabaseContext _context;

        public OfferController(DatabaseContext context)
        {
            _context = context;
        }

        // view all
        public ActionResult Index(string country)
        {
    
            var offers = _context.Offer.Where(o => o.Hotel.City.Country.Name.Contains(country));


            if (offers == null)
                return View(offers);
            else
                return View(offers);
        }


        // GET
        public ActionResult Create()
        {
            var offer = new Offer();
            return View(offer);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Offer offer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(offer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(offer);
        }
        


        // GET: OfferController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OfferController/Edit/5
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

        public ActionResult Details(int id)
        {
            Offer? offer = _context.Offer.First(of => of.OfferId == id);

            if (offer == null)
                return View("Index");
            else
                return View(offer);
        }

        public ActionResult Filter(string country)
        {
            var offers = _context.Offer.Where(o => o.Hotel.City.Country.Name == country);


            if (offers == null)
                return View("Index");
            else
                return View("Index", offers);
        }


        // GET: OfferController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OfferController/Delete/5
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
