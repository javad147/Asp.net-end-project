using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject.Migrations
{
    public class _20210610123456_InitialCreate : Controller
    {
        // GET: _20210610123456_InitialCreate
        public ActionResult Index()
        {
            return View();
        }

        // GET: _20210610123456_InitialCreate/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: _20210610123456_InitialCreate/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: _20210610123456_InitialCreate/Create
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

        // GET: _20210610123456_InitialCreate/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: _20210610123456_InitialCreate/Edit/5
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

        // GET: _20210610123456_InitialCreate/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: _20210610123456_InitialCreate/Delete/5
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
