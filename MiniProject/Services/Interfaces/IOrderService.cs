using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject.Services.Interfaces
{
    public class IOrderService : Controller
    {
        // GET: IOrderService
        public ActionResult Index()
        {
            return View();
        }

        // GET: IOrderService/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IOrderService/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IOrderService/Create
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

        // GET: IOrderService/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IOrderService/Edit/5
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

        // GET: IOrderService/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IOrderService/Delete/5
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
