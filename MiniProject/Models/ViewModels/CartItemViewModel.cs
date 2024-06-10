using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject.Models.ViewModels
{
    public class CartItemViewModel : Controller
    {
        // GET: CartItemViewModel
        public ActionResult Index()
        {
            return View();
        }

        // GET: CartItemViewModel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CartItemViewModel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CartItemViewModel/Create
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

        // GET: CartItemViewModel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CartItemViewModel/Edit/5
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

        // GET: CartItemViewModel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CartItemViewModel/Delete/5
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
