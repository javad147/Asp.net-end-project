using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject.Data
{
    public class SeedData : Controller
    {
        // GET: SeedData
        public ActionResult Index()
        {
            return View();
        }

        // GET: SeedData/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SeedData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SeedData/Create
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

        // GET: SeedData/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SeedData/Edit/5
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

        // GET: SeedData/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SeedData/Delete/5
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
