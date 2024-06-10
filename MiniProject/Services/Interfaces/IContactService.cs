using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject.Services.Interfaces
{
    public class IContactService : Controller
    {
        // GET: IContactService
        public ActionResult Index()
        {
            return View();
        }

        // GET: IContactService/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IContactService/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IContactService/Create
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

        // GET: IContactService/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IContactService/Edit/5
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

        // GET: IContactService/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IContactService/Delete/5
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
