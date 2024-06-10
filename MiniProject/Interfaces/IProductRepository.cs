using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject.Interfaces
{
    public class IProductRepository : Controller
    {
        // GET: IProductRepository
        public ActionResult Index()
        {
            return View();
        }

        // GET: IProductRepository/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IProductRepository/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IProductRepository/Create
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

        // GET: IProductRepository/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IProductRepository/Edit/5
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

        // GET: IProductRepository/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IProductRepository/Delete/5
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
