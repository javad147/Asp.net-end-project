using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject.Areas.Admin
{
    public class AdminAreaRegistration : Controller
    {
        // GET: AdminAreaRegistration
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminAreaRegistration/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminAreaRegistration/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminAreaRegistration/Create
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

        // GET: AdminAreaRegistration/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminAreaRegistration/Edit/5
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

        // GET: AdminAreaRegistration/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminAreaRegistration/Delete/5
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
