using Microsoft.AspNetCore.Mvc;
using OnlineStore.Data;
using OnlineStore.Models;
using System.Diagnostics;

namespace OnlineStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly OnlineStoreContext _context;
        public HomeController(ILogger<HomeController> logger, OnlineStoreContext context)
        {
            _logger = logger;
            _context = context;
        }

        
        public IActionResult Index()
        {
            List<Slider> model = _context.Sliders.Where(x => x.SoftDeleted != true).ToList();
            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
