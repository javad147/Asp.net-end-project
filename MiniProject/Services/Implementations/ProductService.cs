﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject.Services.Implementations
{
    public class ProductService : Controller
    {
        // GET: ProductService
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductService/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductService/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductService/Create
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

        // GET: ProductService/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductService/Edit/5
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

        // GET: ProductService/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductService/Delete/5
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
