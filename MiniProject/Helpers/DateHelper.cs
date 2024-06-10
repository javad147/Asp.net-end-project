using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject.Helpers
{
    public class DateHelper : Controller
    {
        // GET: DateHelper
        public ActionResult Index()
        {
            return View();
        }

        // GET: DateHelper/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DateHelper/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DateHelper/Create
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

        // GET: DateHelper/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DateHelper/Edit/5
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

        // GET: DateHelper/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DateHelper/Delete/5
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
