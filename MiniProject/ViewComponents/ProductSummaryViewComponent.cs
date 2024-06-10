using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiniProject.ViewComponents
{
    public class ProductSummaryViewComponent : Controller
    {
        // GET: ProductSummaryViewComponent
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductSummaryViewComponent/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductSummaryViewComponent/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductSummaryViewComponent/Create
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

        // GET: ProductSummaryViewComponent/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductSummaryViewComponent/Edit/5
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

        // GET: ProductSummaryViewComponent/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductSummaryViewComponent/Delete/5
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
