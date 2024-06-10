using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject.Services.Implementations
{
    public class ContactService : Controller
    {
        // GET: ContactService
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContactService/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContactService/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactService/Create
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

        // GET: ContactService/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContactService/Edit/5
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

        // GET: ContactService/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContactService/Delete/5
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
