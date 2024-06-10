using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject.Areas.Admin.Models
{
    public class UserModel : Controller
    {
        // GET: UserModel
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserModel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserModel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserModel/Create
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

        // GET: UserModel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserModel/Edit/5
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

        // GET: UserModel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserModel/Delete/5
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
