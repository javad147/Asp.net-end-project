using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Data;

namespace OnlineStore.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly OnlineStoreContext _context;

        public CategoryController(OnlineStoreContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Categories.Where(x => x.SoftDeleted != true).ToList();
            return View(model);
        }
        public IActionResult Setup(int? id)
        {

            var model = new Category();
            if (id != null)
            {
                model = _context.Categories.FirstOrDefault(x => x.Id == id);
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Setup(Category model)
        {
            try
            {
                if (model.Id != 0)
                {
                    var existingCategory = _context.Categories.FirstOrDefault(x => x.Id == model.Id);
                    existingCategory.Name = model.Name;
                    _context.Entry(existingCategory).State = EntityState.Modified;
                }
                else
                {
                    _context.Categories.Add(model);
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                return View(model);
            }

            return RedirectToAction("Index");


        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id != 0)
            {
                var existingCategory = _context.Categories.FirstOrDefault(x => x.Id == id);
                existingCategory.SoftDeleted = true;
                _context.Entry(existingCategory).State = EntityState.Modified;
                _context.SaveChanges();

            }
            return RedirectToAction("index");
        }
    }
}
