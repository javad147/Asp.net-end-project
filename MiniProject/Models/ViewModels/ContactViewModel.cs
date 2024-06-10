using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject.Models.ViewModels
{
    public class ContactViewModel : Controller
    {
        // GET: ContactViewModel
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContactViewModel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContactViewModel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactViewModel/Create
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

        // GET: ContactViewModel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContactViewModel/Edit/5
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

        // GET: ContactViewModel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContactViewModel/Delete/5
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
