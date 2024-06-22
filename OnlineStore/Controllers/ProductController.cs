using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using OnlineStore.Data;
using static System.Net.Mime.MediaTypeNames;

namespace OnlineStore.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly OnlineStoreContext _context;

        public ProductController(OnlineStoreContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            var model = _context.Products.Where(x => x.SoftDeleted != true).ToList();
            return View(model);
        }
        public IActionResult Setup(int? id)
        {
            var categories = _context.Categories.Where(x => x.SoftDeleted != true).ToList();
            List<SelectListItem> CategoriesList = new List<SelectListItem>();
            foreach (var item in categories)
            {
                CategoriesList.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString() });
            }
            ViewBag.categories = CategoriesList;
            var model = new Product();
            if (id != null)
            {
                model = _context.Products.FirstOrDefault(x => x.Id == id);
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Setup(Product model, IFormFile myfile)
        {
            try
            {
                if (myfile != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        myfile.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        model.Image = Convert.ToBase64String(fileBytes);
                    }
                }

                if (model.Id != 0)
                {
                    var existingProduct = _context.Products.FirstOrDefault(x => x.Id == model.Id);
                    existingProduct.Name = model.Name;
                    existingProduct.Description = model.Description;
                    existingProduct.Price = model.Price;
                    existingProduct.CategoryId = model.CategoryId;
                    if (!string.IsNullOrEmpty(model.Image))
                    {
                        existingProduct.Image = model.Image;
                    }
                    _context.Entry(existingProduct).State = EntityState.Modified;

                }
                else
                {
                    _context.Products.Add(model);
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                var categories = _context.Categories.Where(x => x.SoftDeleted != true).ToList();
                List<SelectListItem> CategoriesList = new List<SelectListItem>();
                foreach (var item in categories)
                {
                    CategoriesList.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString() });
                }
                ViewBag.categories = CategoriesList;
                return View(model);
            }

            return RedirectToAction("Index");


        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id != 0)
            {
                var existingProduct = _context.Products.FirstOrDefault(x => x.Id == id);
                existingProduct.SoftDeleted = true;
                _context.Entry(existingProduct).State = EntityState.Modified;
                _context.SaveChanges();
            }
            return RedirectToAction("index");
        }

    }
}