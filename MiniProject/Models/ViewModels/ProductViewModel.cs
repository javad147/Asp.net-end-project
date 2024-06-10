using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject.Models.ViewModels
{
    public class ProductViewModel : Controller
    {
        // GET: ProductViewModel
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductViewModel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductViewModel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductViewModel/Create
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

        // GET: ProductViewModel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductViewModel/Edit/5
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

        // GET: ProductViewModel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductViewModel/Delete/5
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
