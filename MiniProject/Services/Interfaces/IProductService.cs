using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject.Services.Interfaces
{
    public class IProductService : Controller
    {
        // GET: IProductService
        public ActionResult Index()
        {
            return View();
        }

        // GET: IProductService/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IProductService/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IProductService/Create
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

        // GET: IProductService/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IProductService/Edit/5
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

        // GET: IProductService/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IProductService/Delete/5
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
