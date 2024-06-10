using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject.Services.Interfaces
{
    public class ICartService : Controller
    {
        // GET: ICartService
        public ActionResult Index()
        {
            return View();
        }

        // GET: ICartService/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ICartService/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ICartService/Create
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

        // GET: ICartService/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ICartService/Edit/5
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

        // GET: ICartService/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ICartService/Delete/5
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
