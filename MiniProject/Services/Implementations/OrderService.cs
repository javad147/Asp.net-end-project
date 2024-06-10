using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject.Services.Implementations
{
    public class OrderService : Controller
    {
        // GET: OrderService
        public ActionResult Index()
        {
            return View();
        }

        // GET: OrderService/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderService/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderService/Create
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

        // GET: OrderService/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderService/Edit/5
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

        // GET: OrderService/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderService/Delete/5
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
