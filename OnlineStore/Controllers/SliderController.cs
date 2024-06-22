using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Data;

namespace OnlineStore.Controllers
{
    [Authorize]
    public class SliderController : Controller
    {
        private readonly OnlineStoreContext _context;

        public SliderController(OnlineStoreContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Sliders.Where(x => x.SoftDeleted != true).ToList();
            return View(model);
        }
        public IActionResult Setup(int? id)
        {

            var model = new Slider();
            if (id != null)
            {
                model = _context.Sliders.FirstOrDefault(x => x.Id == id);
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Setup(Slider model, IFormFile myfile)
        {
            try
            {
                using (var ms = new MemoryStream())
                {
                    myfile.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    model.Image = Convert.ToBase64String(fileBytes);
                    // act on the Base64 data
                }
                if (model.Id != 0)
                {
                    var existingSliders = _context.Sliders.FirstOrDefault(x => x.Id == model.Id);
                    existingSliders.Image = model.Image;
                    _context.Entry(existingSliders).State = EntityState.Modified;
                }
                else
                {
                    _context.Sliders.Add(model);
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
                var existingSliders = _context.Sliders.FirstOrDefault(x => x.Id == id);
                existingSliders.SoftDeleted = true;
                _context.Entry(existingSliders).State = EntityState.Modified;
                _context.SaveChanges();

            }
            return RedirectToAction("index");
        }
    }
}

