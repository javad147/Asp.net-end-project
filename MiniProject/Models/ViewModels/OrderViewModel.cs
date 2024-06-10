﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject.Models.ViewModels
{
    public class OrderViewModel : Controller
    {
        // GET: OrderViewModel
        public ActionResult Index()
        {
            return View();
        }

        // GET: OrderViewModel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderViewModel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderViewModel/Create
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

        // GET: OrderViewModel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderViewModel/Edit/5
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

        // GET: OrderViewModel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderViewModel/Delete/5
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
