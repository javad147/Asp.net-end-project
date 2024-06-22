using Microsoft.AspNetCore.Mvc;

namespace OnlineStore.Controllers
{
    public class AdvertisingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
