using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject.Migrations
{
    public class ApplicationDbContextModelSnapshot : Controller
    {
        // GET: ApplicationDbContextModelSnapshot
        public ActionResult Index()
        {
            return View();
        }

        // GET: ApplicationDbContextModelSnapshot/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ApplicationDbContextModelSnapshot/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApplicationDbContextModelSnapshot/Create
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

        // GET: ApplicationDbContextModelSnapshot/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApplicationDbContextModelSnapshot/Edit/5
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

        // GET: ApplicationDbContextModelSnapshot/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApplicationDbContextModelSnapshot/Delete/5
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
